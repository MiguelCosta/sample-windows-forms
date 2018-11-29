using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Services.Countries;

namespace Mpc.WinFormsIoC.Presentation.Countries
{
    public partial class FrmCountryList : Form
    {
        private ICountryService _countryService;

        public FrmCountryList(ICountryService countryService)
        {
            InitializeComponent();
            _countryService = countryService;
        }

        private async void FrmCountryList_Load(object sender, System.EventArgs e)
        {
            using (new Core.ShowLoading())
            {
                var countries = await _countryService.GetAllAsync();

                countryDtoBindingSource.DataSource = countries;
                countryDtoBindingSource.ResetBindings(false);
            }
        }
    }
}
