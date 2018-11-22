namespace Mpc.WinFormsIoC.Presentation
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Config.IoC.Init();
            var frmMain = Config.IoC.GetForm<FrmMain>();

            Application.ThreadException += Application_ThreadException;

            Application.Run(frmMain);
        }

        /// <summary>
        /// Event to Catch Application Exceptions
        /// </summary>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error");
        }
    }
}
