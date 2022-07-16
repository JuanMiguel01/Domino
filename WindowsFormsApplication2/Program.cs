using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    static class Program
    {
        [DllImport("kernel32", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32", SetLastError = true)]
        static extern bool AttachConsole(int dwProcess);

        [DllImport("user32")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var wind = GetForegroundWindow();
            //int id;

            //GetWindowThreadProcessId(wind, out id);
            //var proc = Process.GetProcessById(id);
            //if (proc.ProcessName == "cmd")
            //{
            //    AttachConsole(proc.Id);
            //} else
            //{
            //    AllocConsole();
            //}
            //Console.WriteLine("Hello World ");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInicio());
        }
    }
}
