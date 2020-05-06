using System;

namespace Mpc.WinFormsIoC.PresentationCore.Core.Events
{
    public static class Login
    {
        public static event EventHandler<SuccessLoginEventArgs> SuccessLogin;

        public static void OnSuccessLogin(object sender, SuccessLoginEventArgs e)
        {
            if (SuccessLogin != null)
            {
                SuccessLogin(sender, e);
                ApplicationContext.Username = e.Username;
            }
        }
    }
}
