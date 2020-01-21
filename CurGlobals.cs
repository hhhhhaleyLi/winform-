using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlashRecovery
{
    class CurGlobals
    {
        [DllImport("user32.dll", EntryPoint = "SetParent", SetLastError = true)]
        public static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr32(HandleRef hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, ref SENDMESSAGETRANSFERSTRUCT lParam);

        [DllImport("user32.dll", EntryPoint = "MoveWindow", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int cx, int cy, bool repaint);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool ShowWindow(IntPtr hWnd, short state);

        /// <summary> 
        /// 该函数设置由不同线程产生的窗口的显示状态。 
        /// </summary> 
        /// <param name="hWnd">窗口句柄</param> 
        /// <param name="cmdShow">指定窗口如何显示。查看允许值列表，请查阅ShowWlndow函数的说明部分。</param> 
        /// <returns>如果函数原来可见，返回值为非零；如果函数原来被隐藏，返回值为零。</returns> 
        [DllImport("User32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);

        /// <summary> 
        /// 该函数将创建指定窗口的线程设置到前台，并且激活该窗口。键盘输入转向该窗口，并为用户改各种可视的记号。系统给创建前台窗口的线程分配的权限稍高于其他线程。 
        /// </summary> 
        /// <param name="hWnd">将被激活并被调入前台的窗口句柄。</param> 
        /// <returns>如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零。</returns> 
        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        //SendMessage用结构体
        public struct SENDMESSAGETRANSFERSTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        #region 硬件检测相关
        //查找设备
        [DllImport("FlashControlNAND.dll", EntryPoint = "FindDev")]
        public static extern int FindDev();
        //初始化设备
        [DllImport("FlashControlNAND.dll", EntryPoint = "InitDev")]
        public static extern int InitDev(StringBuilder sysHexPathStringBuilder, StringBuilder deviceID);
        #endregion

        #region 设置窗体不可操作
        [DllImport("user32.dll", EntryPoint = "EnableWindow")]
        public static extern bool EnableWindow(IntPtr hwnd, int bEnabled);
        #endregion

        #region 测脚
        //Bank，座信息结构体
        [StructLayout(LayoutKind.Sequential)]
        public struct BankInfoStruct
        {
            public int bank;            //Bank
            public int dev;             //座
        };

        //测脚，连接,短路
        [DllImport("FlashControlNAND.dll", EntryPoint = "TestPin")]
        public static extern int TestPin(
            int[] connectStatus,
            int[] shortCircuitStatus,
            StringBuilder footMeasurementPathStringBuilder,
            ref BankInfoStruct bankInfoParam
        );
        #endregion
    }
}
