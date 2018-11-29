using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Users;
using Mpc.WinFormsIoC.Presentation.Core;
using Mpc.WinFormsIoC.Presentation.Core.Helpers;

namespace Mpc.WinFormsIoC.Presentation.Users
{
    public partial class FrmUserList : Form
    {
        private IUserService _userService;

        public FrmUserList(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            var userSelected = DgvUsers.GetSelectedItem<UserDto>();

            if (userSelected != null)
            {
                var formEdit = Config.IoC.GetForm<FrmUserEdit>();
                formEdit.UserId = userSelected.Id;
                OpenFormsHelpers.OpenFormDialog(formEdit);
            }

            await FillUsersAsync();
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            OpenFormsHelpers.OpenFormDialog<FrmUserEdit>();

            await FillUsersAsync();
        }

        private async Task FillUsersAsync()
        {
            using (new ShowLoading())
            {
                var users = await _userService.GetAllAsync();

                userDtoBindingSource.DataSource = users;
                userDtoBindingSource.ResetBindings(false);
            }
        }

        private async void FrmUserList_Load(object sender, EventArgs e)
        {
            await FillUsersAsync();
        }
    }
}
