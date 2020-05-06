using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Users;

namespace Mpc.WinFormsIoC.PresentationCore.Users
{
    public partial class FrmUserEdit : Form
    {
        private IUserService _userService;

        public FrmUserEdit(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        public int? UserId { get; set; } = null;

        private async void BtnSave_ClickAsync(object sender, System.EventArgs e)
        {
            if (UserId.HasValue)
            {
                await UpdateUserAsync();
                Core.Messages.Information.ShowMessage("User updated", "Users");
            }
            else
            {
                await SaveUserAsync();
                Core.Messages.Information.ShowMessage("User created", "Users");
            }
            Close();
        }

        private void FillUser(UserDto user)
        {
            TxtId.Text = user.Id.ToString();
            TxtEmail.Text = user.Email;
            TxtName.Text = user.Name;
            TxtPassword.Text = user.Password;
            TxtUsername.Text = user.Username;
        }

        private async void FrmUserEdit_Load(object sender, System.EventArgs e)
        {
            if (!UserId.HasValue)
            {
                return;
            }

            using (new Core.ShowLoading())
            {
                var existUser = await _userService.FindAsync(UserId.Value);

                if (existUser != null)
                {
                    FillUser(existUser);
                }
            }
        }

        private UserDto GetUser()
        {
            var user = new UserDto
            {
                Email = TxtEmail.Text,
                Name = TxtName.Text,
                Password = TxtPassword.Text,
                Username = TxtUsername.Text
            };

            return user;
        }

        private async Task SaveUserAsync()
        {
            var user = GetUser();

            await _userService.CreateAsync(user);
        }

        private async Task UpdateUserAsync()
        {
            var user = GetUser();
            user.Id = UserId.Value;
            user.Password = string.Empty;

            await _userService.UpdateAsync(user);
        }
    }
}
