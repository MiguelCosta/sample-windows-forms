namespace Mpc.WinFormsIoC.Presentation
{
    using System;
    using System.Windows.Forms;
    using Mpc.WinFormsIoC.Application.Services.Users;
    using Mpc.WinFormsIoC.Presentation.Config;
    using Mpc.WinFormsIoC.Presentation.Core;

    public partial class FrmMain : Form
    {
        private IUserService _userService;

        public FrmMain(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            var frmCountries = IoC.GetForm<Countries.FrmCountries>();
            frmCountries.ShowDialog();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var frmUserEdit = IoC.GetForm<Users.FrmUserEdit>();
            frmUserEdit.ShowDialog();
        }

        private async void BtnGet_Click(object sender, EventArgs e)
        {
            using (new ShowLoading())
            {
                var users = await _userService.GetAllAsync();

                userDtoBindingSource.DataSource = users;
                userDtoBindingSource.ResetBindings(false);
            }
        }
    }
}
