using System;
using System.Threading;
using System.Windows.Forms;

namespace Mpc.WinFormsIoC.PresentationCore
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            Config.IoC.Init();
            var frmMain = Config.IoC.GetForm<FrmMain>();

            System.Windows.Forms.Application.ThreadException += Application_ThreadException;

            System.Windows.Forms.Application.Run(frmMain);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error");
        }
    }
}
