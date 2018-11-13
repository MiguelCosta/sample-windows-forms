using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Services.Countries;

namespace Mpc.WinFormsIoC.Presentation.Countries
{
    public partial class FrmCountries : Form
    {
        private ICountryService _countryService;

        public FrmCountries(ICountryService countryService)
        {
            InitializeComponent();
            _countryService = countryService;
        }

        private async void FrmCountries_Load(object sender, System.EventArgs e)
        {
            var countries = await _countryService.GetAllAsync();

            countryDtoBindingSource.DataSource = countries;
            countryDtoBindingSource.ResetBindings(false);
        }
    }
}
