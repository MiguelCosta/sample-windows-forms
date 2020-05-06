namespace Mpc.WinFormsIoC.PresentationCore
{
    using System;
    using System.Windows.Forms;
    using Mpc.WinFormsIoC.Application.Services.Users;
    using Mpc.WinFormsIoC.PresentationCore.Config;

    public partial class FrmMain : Form
    {
        private IUserService _userService;

        public FrmMain(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            Core.ApplicationContext.MainForm = this;
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            var frmCountries = IoC.GetForm<Countries.FrmCountryList>();
            frmCountries.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Core.Events.Login.SuccessLogin += Login_SuccessLogin;

            var frmLogin = IoC.GetForm<Users.FrmLogin>();
            frmLogin.ShowDialog();
        }

        private void Login_SuccessLogin(object sender, Core.Events.SuccessLoginEventArgs e)
        {
            statusUserName.Text = e.Username;
        }

        private void menuMainConfigurationCountries_Click(object sender, EventArgs e)
        {
            Core.Helpers.OpenFormsHelpers.OpenForm<Countries.FrmCountryList>();
        }

        private void menuMainConfigurationUsers_Click(object sender, EventArgs e)
        {
            Core.Helpers.OpenFormsHelpers.OpenForm<Users.FrmUserList>();
        }
    }
}
