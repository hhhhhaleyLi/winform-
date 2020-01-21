using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace FlashRecovery
{
    public partial class FlashRecovery : Form
    {
        //记录当前exe(/button)个数 从0开始(最多8个)
        private int _index = -1;
        //标识点击的是哪个button
        private int _clickIndex;

        private EventHandler appIdleEvent = null;
        //主控程序的panel
        private Control parentCon = null;

        private string strGUID = "";
        //传给主控程序的参数(用于标识是新建任务还是打开任务)
        private int _argument;
        //存储主控程序的集合
        private List<System.Diagnostics.Process> m_AppProcess = new List<System.Diagnostics.Process>();
        //记录鼠标按下时窗体的位置
        private Point _mousePos;
        //记录是否触发了MouseDown事件
        private bool _isMouseDown;
        //记录初始时窗体宽
        private int _formWidth;
        //记录初始时窗体高
        private int _formHeight;
        //标识
        private bool _isCopy;
        //设备ID
        private string _deviceId;


        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 0x10000000;
        private const int WM_SETTEXT = 0x000C;
        private const int WM_COPYDATA = 0x004A;

        #region 检测硬件插拔
        public const int WM_DEVICECHANGE = 0x219;               //系统硬件改变发出的系统消息
        public const int DBT_DEVICEARRIVAL = 0x8000;            //系统检测到设备已经插入，并且已经处于可用转态
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;     //系统检测到设备已经卸载或者拔出
        #endregion

        //钩子（winform中直接重写WndProc即可进行消息拦截）
        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == WM_COPYDATA)
                {
                    CurGlobals.SENDMESSAGETRANSFERSTRUCT temp = (CurGlobals.SENDMESSAGETRANSFERSTRUCT)Marshal.PtrToStructure(m.LParam, typeof(CurGlobals.SENDMESSAGETRANSFERSTRUCT));
                    //新建/打开任务失败
                    if (temp.cbData == 0)
                    {
                        _clickIndex = _index;
                        deleteBtn_Click(null, null);
                    }
                    //新建/打开任务成功
                    if (temp.cbData > 0)
                    {
                        
                    };
                }

                if (m.Msg == WM_DEVICECHANGE)
                {
                    switch (m.WParam.ToInt32())
                    {
                        case DBT_DEVICEARRIVAL:
                            if (!_isCopy)
                            {
                                _isCopy = true;
                                //检测硬件设备是否连接成功
                                IsDeviceExist("in");
                            }
                            break;
                        case DBT_DEVICEREMOVECOMPLETE:
                            _isCopy = false;
                            //检测硬件设备是否连接成功
                            IsDeviceExist("out");
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("异常");
            }
            finally
            {
                base.WndProc(ref m);
            }
        }

        private void IsDeviceExist(string status)
        {
            //检测硬件设备是否连接成功
            ManagementObjectCollection collection = null;
            bool isExist = false;
            using (BackgroundWorker bw = new BackgroundWorker())
            {
                bw.DoWork += new DoWorkEventHandler((sender1, e1) =>
                {
                    using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                    {
                        collection = searcher.Get();
                        searcher.Dispose();
                    }
                });
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler((sender2, e2) =>
                {
                    isExist = false;
                    foreach (ManagementBaseObject device in collection)
                    {
                        //获取包含PID和VID的字符串
                        string deviceId = (string)device.GetPropertyValue("DeviceID");
                        //这里的XXX填写自己产品硬件设备的PID和VID，连接硬件后在设备管理器中可以查到
                        if ("XXX".Equals(deviceId))
                        {
                            isExist = true;
                            break;
                        }
                    }
                    //未连接硬件设备
                    if (!isExist)
                    {
                        this.deviceIdLabel.Text = @"00000000";
                        this.connStatus.Text = @"未连接设备";
                        this.connStatusImage.Image = global::FlashRecovery.Properties.Resources.未连接设备;
                        if ("out".Equals(status)) MessageBox.Show("检测到硬件设备断开连接，请重新插入硬件设备恢复软件使用");
                        //设置窗体不可操作
                        CurGlobals.EnableWindow(this.Handle, 0);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(_deviceId))
                        {
                            //获取设备ID
                            //...
                        }
                        this.deviceIdLabel.Text = _deviceId;
                        this.connStatus.Text = @"成功连接设备";
                        this.connStatusImage.Image = global::FlashRecovery.Properties.Resources.成功连接设备;
                        //设置窗体可操作
                        CurGlobals.EnableWindow(this.Handle, 1);
                    }
                });
                bw.RunWorkerAsync();
            }
        }

        public FlashRecovery()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            _index++;
            //最多支持8个任务
            if (_index >= 7)
            {
                newBtn.Enabled = false;
                openBtn.Enabled = false;
            }
            #region 增加标签
            TabPage tp = new TabPage();
            tp.Text = $@"任务{_index + 1}";
            tp.Name = $@"btn{_index}";
            exeTabControl.TabPages.Add(tp);
            #endregion
            //调用业务进程exe
            string filePath = System.IO.Directory.GetCurrentDirectory() + @"\XXX.exe";
            appIdleEvent = new EventHandler(Application_Idle);
            parentCon = tp;
            strGUID = "任务" + (_index + 1);
            _argument = 1;
            Start(filePath);
            _clickIndex = _index;
            //设置选项卡中选中最新创建的选项
            exeTabControl.SelectedIndex = _index;
            //设置关闭按钮有效性
            deleteBtn.Enabled = true;
            //设置封面不可见
            this.backgroundImagePanel.Visible = false;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            _index++;
            //最多支持8个任务
            if (_index >= 7)
            {
                newBtn.Enabled = false;
                openBtn.Enabled = false;
            }
            #region 增加标签
            TabPage tp = new TabPage();
            tp.Text = $@"任务{_index + 1}";
            tp.Name = $@"btn{_index}";
            exeTabControl.TabPages.Add(tp);
            #endregion
            //调用业务进程exe
            string filePath = System.IO.Directory.GetCurrentDirectory() + @"\XXX.exe";
            appIdleEvent = new EventHandler(Application_Idle);
            parentCon = tp;
            strGUID = "任务" + (_index + 1);
            _argument = 2;
            Start(filePath);
            _clickIndex = _index;
            //设置选项卡中选中最新创建的选项
            exeTabControl.SelectedIndex = _index;
            //设置关闭按钮有效性
            deleteBtn.Enabled = true;
            //设置封面不可见
            this.backgroundImagePanel.Visible = false;
        }

        public IntPtr Start(string filePath)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(filePath);
                info.UseShellExecute = true;
                info.CreateNoWindow = false;
                info.Arguments = $"{this.exeTabControl.Width - 8},{this.exeTabControl.Height - 32}";
                info.WindowStyle = ProcessWindowStyle.Minimized;
                m_AppProcess.Add(Process.Start(info));
                m_AppProcess[_index].WaitForInputIdle();
                Application.Idle += appIdleEvent;
            }
            catch (Exception)
            {
                if (m_AppProcess.Count > _index && m_AppProcess?[_index] != null)
                {
                    if (!m_AppProcess[_index].HasExited)
                        m_AppProcess[_index].Kill();
                    m_AppProcess = null;
                }
            }

            return m_AppProcess[_index].Handle;
        }

        //确保应用程序嵌入到容器中
        private void Application_Idle(object sender, EventArgs e)
        {
            if (this.m_AppProcess?[_index] == null || this.m_AppProcess[_index].HasExited)
            {
                this.m_AppProcess[_index] = null;
                Application.Idle -= appIdleEvent;
                return;
            }

            while (m_AppProcess[_index].MainWindowHandle == IntPtr.Zero)
            {
                System.Threading.Thread.Sleep(100);
                m_AppProcess[_index].Refresh();
            }

            Application.Idle -= appIdleEvent;
            EmbedProcess(m_AppProcess[_index], parentCon, 0);
        }

        //将指定的程序嵌入指定的控件
        private void EmbedProcess(Process app, Control con, int flag)
        {
            if (app == null || app.MainWindowHandle == IntPtr.Zero || con == null)
                return;
            //设置窗体展示方式
            CurGlobals.ShowWindow(app.MainWindowHandle, (short)5);
            //设置父窗体
            CurGlobals.SetParent(app.MainWindowHandle, con.Handle);
            SetWindowLong(new HandleRef(this, app.MainWindowHandle), GWL_STYLE, WS_VISIBLE);
            CurGlobals.SendMessage(app.MainWindowHandle, WM_SETTEXT, IntPtr.Zero, strGUID);
            CurGlobals.MoveWindow(app.MainWindowHandle, 0, 0, con.Width, con.Height, true);

            if (flag != -1)
            {
                CurGlobals.SENDMESSAGETRANSFERSTRUCT temp = new CurGlobals.SENDMESSAGETRANSFERSTRUCT();
                temp.cbData = _argument;
                temp.dwData = Handle;
                CurGlobals.SendMessage(app.MainWindowHandle, WM_COPYDATA, IntPtr.Zero, ref temp);
            }
        }

        private static IntPtr SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong)
        {
            if (IntPtr.Size == 4)
            {
                return CurGlobals.SetWindowLongPtr32(hWnd, nIndex, dwNewLong);
            }

            return CurGlobals.SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
        }

        private void FlashRecovery_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Process p in m_AppProcess)
            {
                if (p == null) break;
                p.Kill();
                p.Dispose();
            }
            Dispose();
        }

        private void closeBtn2_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region 窗体移动
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            _mousePos = Cursor.Position;
            _isMouseDown = true;
        }

        private void titlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            this.Focus();
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown) return;

            Point tempPos = Cursor.Position;
            this.Location = new Point(this.Location.X + (tempPos.X - _mousePos.X), this.Location.Y + (tempPos.Y - _mousePos.Y));
            _mousePos = Cursor.Position;
        }
        #endregion

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //parentCon设置为null
            parentCon = null;
            //kill选中的程序
            m_AppProcess[_clickIndex].Kill();
            m_AppProcess[_clickIndex].Dispose();
            //进程数组中删除选中的程序
            m_AppProcess.RemoveAt(_clickIndex);
            //标签行中删除button
            //tagPanel.Controls.RemoveAt(_index);
            exeTabControl.TabPages.RemoveAt(_clickIndex);
            //重新给标签中的button设置name及text
            for (int i = 0; i < exeTabControl.TabPages.Count; i++)
            {
                TabPage btn = exeTabControl.TabPages[i];
                btn.Name = $@"btn{i}";
                btn.Text = $@"任务{i + 1}";
            }

            _index--;
            if (_index >= 0)
            {
                _clickIndex = _index;
            }
            else
            {
                deleteBtn.Enabled = false;
                this.backgroundImagePanel.Visible = true;
            }
            if (_index < 7)
            {
                newBtn.Enabled = true;
                openBtn.Enabled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (exeTabControl.SelectedTab == null) return;
            string tempName = exeTabControl.SelectedTab.Name;
            _clickIndex = int.Parse(tempName.Substring(tempName.Length - 1, 1));
        }

        //弹出计算器
        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            Process calc = new Process();
            calc.StartInfo.FileName = "calc";
            calc.Start();
        }

        #region 窗体改变大小
        private enum MouseDirection
        {
            Horizontal, //水平方向，只改变宽度
            Vertical,   //垂直方向，只改变高度
            Declining,  //倾斜方向，同时改变宽和高
            None,       //未改变
        }

        //是否改变了窗体大小
        private bool _isChangeSize;
        //表示拖动的方向
        private MouseDirection _direction = MouseDirection.None;
        //鼠标移动位置变量
        private Point _mouseOff;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //记录鼠标位置
            _mouseOff = new Point(-e.X, -e.Y);
            #region 当鼠标的位置处于边缘时，允许改变大小
            if (e.Location.X >= this.Width - 10 && e.Location.Y >= this.Height - 10)
            {
                _isChangeSize = true;
            }
            else if (e.Location.Y >= this.Height - 6)
            {
                _isChangeSize = true;
            }
            //改变宽度
            else if (e.Location.X >= this.Width - 6)
            {
                _isChangeSize = true;
            }
            else
            {
                this.Cursor = Cursors.Arrow;
                _isChangeSize = false;

            }
            #endregion
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _isChangeSize = false;
            _direction = MouseDirection.None;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location.X >= this.Width - 10 && e.Location.Y >= this.Height - 10)
            {
                this.Cursor = Cursors.SizeNWSE;
                _direction = MouseDirection.Declining;
            }
            //只改变宽度
            else if (e.Location.X >= this.Width - 6)
            {
                this.Cursor = Cursors.SizeWE;
                _direction = _direction == MouseDirection.Declining ? MouseDirection.Declining : MouseDirection.Horizontal;
            }
            else if (e.Location.Y >= this.Height - 6)
            {
                this.Cursor = Cursors.SizeNS;
                _direction = _direction == MouseDirection.Declining ? MouseDirection.Declining : MouseDirection.Vertical;
            }
            else
            {
                this.Cursor = Cursors.Arrow;
            }

            //改变窗体大小
            ResizeWindow();
        }

        private void ResizeWindow()
        {
            if (!_isChangeSize)
                return;
            //外皮窗体最小为初始大小，为了适应主控主窗体中ReoGrid表格
            if (_direction == MouseDirection.Horizontal)
            {
                this.Width = MousePosition.X - this.Left >= _formWidth ? MousePosition.X - this.Left : _formWidth;
            }
            else if (_direction == MouseDirection.Vertical)
            {
                this.Height = MousePosition.Y - this.Top >= _formHeight ? MousePosition.Y - this.Top : _formHeight;
            }
            else if (_direction == MouseDirection.Declining)
            {
                this.Width = MousePosition.X - this.Left >= _formWidth ? MousePosition.X - this.Left : _formWidth;
                this.Height = MousePosition.Y - this.Top >= _formHeight ? MousePosition.Y - this.Top : _formHeight;
            }
        }

        private void bottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //记录鼠标位置
            _mouseOff = new Point(-e.X, -e.Y);
            #region 当鼠标的位置处于边缘时，允许改变大小
            if (e.Location.X >= this.Width - 10 && e.Location.Y >= this.bottomPanel.Height - 10)
            {
                _isChangeSize = true;
            }
            else if (e.Location.Y >= this.bottomPanel.Height - 6)
            {
                _isChangeSize = true;
            }
            //改变宽度
            else if (e.Location.X >= this.Width - 6)
            {
                _isChangeSize = true;
            }
            else
            {
                this.Cursor = Cursors.Arrow;
                _isChangeSize = false;

            }
            #endregion
        }

        private void bottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _isChangeSize = false;
            _direction = MouseDirection.None;
        }

        private void bottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location.X >= this.Width - 10 && e.Location.Y >= this.bottomPanel.Height - 10)
            {
                this.Cursor = Cursors.SizeNWSE;
                _direction = MouseDirection.Declining;
            }
            //只改变宽度
            else if (e.Location.X >= this.Width - 6)
            {
                this.Cursor = Cursors.SizeWE;
                _direction = _direction == MouseDirection.Declining ? MouseDirection.Declining : MouseDirection.Horizontal;
            }
            else if (e.Location.Y >= this.bottomPanel.Height - 2)
            {
                this.Cursor = Cursors.SizeNS;
                _direction = _direction == MouseDirection.Declining ? MouseDirection.Declining : MouseDirection.Vertical;
            }
            else
            {
                this.Cursor = Cursors.Arrow;
            }

            //改变窗体大小
            ResizeWindow();
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern bool SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_SYSCOMMAND = 0x0112;
        //最大化
        private const int SC_MAXIMIZE = 0xF030;
        //还原
        private const int SC_RESTORE = 0xF120;

        private void titlePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.maxBtn.BackgroundImage = WindowState == FormWindowState.Maximized ? global::FlashRecovery.Properties.Resources.最大化 : global::FlashRecovery.Properties.Resources.还原窗口;
            //防止遮挡任务栏
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            int wParam = this.WindowState == FormWindowState.Maximized ? SC_RESTORE : SC_MAXIMIZE;
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, wParam, 0);
        }
        #endregion

        private void maxBtn_Click(object sender, EventArgs e)
        {
            this.maxBtn.BackgroundImage = WindowState == FormWindowState.Maximized ? global::FlashRecovery.Properties.Resources.最大化 : global::FlashRecovery.Properties.Resources.还原窗口;
            //防止遮挡任务栏
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            int wParam = this.WindowState == FormWindowState.Maximized ? SC_RESTORE : SC_MAXIMIZE;
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, wParam, 0);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FlashRecovery_Resize(object sender, EventArgs e)
        {
            Refresh();

            //通知业务进程改变窗体大小
            CurGlobals.SENDMESSAGETRANSFERSTRUCT temp = new CurGlobals.SENDMESSAGETRANSFERSTRUCT();
            temp.dwData = this.Handle;
            //设置业务进程的窗体大小  
            string tempSize = $"{this.exeTabControl.Width - 5},{this.exeTabControl.Height - 5}".PadLeft(20, '0');
            byte[] arr = System.Text.Encoding.Default.GetBytes(tempSize);
            //参数的长度
            temp.cbData = arr.Length + 1;
            //业务进程窗体大小参数
            temp.lpData = tempSize;
            //向每个进程发消息
            foreach (Process p in m_AppProcess)
            {
                CurGlobals.SendMessage(p.MainWindowHandle, WM_COPYDATA, IntPtr.Zero, ref temp);
            }
        }

        private void FlashRecovery_Load(object sender, EventArgs e)
        {
            //记录窗体初始宽度
            _formWidth = this.Width;
            //记录窗体初始高度
            _formHeight = this.Height;

            #region 检测是否连接硬件设备
            ManagementObjectCollection collection;
            //获取所有连接的USB设备
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
            {
                collection = searcher.Get();
                searcher.Dispose();
            }

            string deviceID = "";
            //获取硬件设备ID  deviceID
            //...
            _deviceId = deviceID;

            bool isExist = false;
            //判断产品硬件设备是否连接
            foreach (ManagementBaseObject device in collection)
            {
                string deviceId = (string)device.GetPropertyValue("DeviceID");
                //连接硬件设备
                if ("XXX".Equals(deviceId))
                {
                    isExist = true;
                    this.connStatus.Text = @"成功连接设备";
                    this.connStatusImage.Image = global::FlashRecovery.Properties.Resources.成功连接设备;
                    this.deviceIdLabel.Text = deviceID.ToString();
                    break;
                }
            }
            //未连接硬件设备
            if (!isExist)
            {
                MessageBox.Show("未检测到硬件设备，请连接硬件设备", "警告", MessageBoxButtons.OK);
                //设置窗体不可操作
                CurGlobals.EnableWindow(this.Handle, 0);
            }
            #endregion
        }
    }
}
