using System;
using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Services.Users;

namespace Mpc.WinFormsIoC.Presentation.Users
{
    public partial class FrmLogin : Form
    {
        private IUserService _userService;

        public FrmLogin(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = TxtUsername.Text;
            var password = TxtPassword.Text;

            var login = false;

            using (new Core.ShowLoading())
            {
                login = await _userService.LoginAsync(username, password);
            }

            if (login)
            {
                var args = new Core.Events.SuccessLoginEventArgs
                {
                    Username = username
                };
                Core.Events.Login.OnSuccessLogin(this, args);
                Close();
            }
            else
            {
                Core.Messages.Information.ShowMessage("Invalid Login", "Login");
            }
        }
    }
}
