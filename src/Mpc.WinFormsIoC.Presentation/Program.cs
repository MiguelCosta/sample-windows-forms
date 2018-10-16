namespace Mpc.WinFormsIoC.Presentation
{
    using System;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            Config.IoC.Init();
            var frmMain = Config.IoC.GetForm<FrmMain>();

            System.Windows.Forms.Application.Run(frmMain);
        }
    }
}
