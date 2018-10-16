using System;
using Mpc.WinFormsIoC.Application.Services.Users;

namespace Mpc.WinFormsIoC.Presentation
{
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
            IUserService userService = new UserService();
            System.Windows.Forms.Application.Run(new FrmMain(userService));
        }
    }
}
