using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Users;

namespace Mpc.WinFormsIoC.Presentation.Users
{
    public partial class FrmUserEdit : Form
    {
        private IUserService _userService;

        public FrmUserEdit(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void BtnSave_ClickAsync(object sender, System.EventArgs e)
        {
            var user = new UserDto
            {
                Email = TxtEmail.Text,
                Id = int.Parse(TxtId.Text),
                Name = TxtName.Text,
                Password = TxtPassword.Text,
                Username = TxtUsername.Text
            };

            await _userService.CreateAsync(user).ConfigureAwait(false);

            MessageBox.Show("User created");
        }
    }
}
