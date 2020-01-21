using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashRecovery
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process instance = GetRunningInstance();
            if (instance == null)
            {
                Application.Run(new FlashRecovery());
            }
            else
            {
                HandleRunningInstance(instance);
            }
        }

        public static Process GetRunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process p in processes)
            {
                if (p.Id != current.Id)
                {
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        return p;
                    }
                }
            }
            return null;
        }

        public static void HandleRunningInstance(Process instance)
        {
            CurGlobals.ShowWindowAsync(instance.MainWindowHandle, 1);
            CurGlobals.SetForegroundWindow(instance.MainWindowHandle);
        }
    }
}
