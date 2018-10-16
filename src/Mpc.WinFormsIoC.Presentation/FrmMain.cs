namespace Mpc.WinFormsIoC.Presentation
{
    using System;
    using System.Windows.Forms;
    using Mpc.WinFormsIoC.Application.Services.Users;

    public partial class FrmMain : Form
    {
        private IUserService _userService;

        public FrmMain(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void BtnCreate_ClickAsync(object sender, EventArgs e)
        {
            await _userService.CreateAsync(txtUsername.Text, txtName.Text).ConfigureAwait(false);
        }

        private async void BtnGet_Click(object sender, EventArgs e)
        {
            var name = await _userService.GetNameAsync(txtUsername.Text).ConfigureAwait(false);
            txtName.Text = name;
        }
    }
}
