using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PhanMemAutoShutdown2
{
    class PowerBoard
    {
        // Fields
        private const int MONITOR_OFF = 2;
        private const int SC_MONITORPOWER = 61808;
        private const int WM_SYSCOMMAND = 274;

        // Methods 
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        public static void TurnOffLCD()
        {
            SendMessage(FindWindow(null, null).ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
