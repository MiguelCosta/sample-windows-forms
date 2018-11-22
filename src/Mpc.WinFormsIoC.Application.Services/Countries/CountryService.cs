namespace Mpc.WinFormsIoC.Application.Services.Countries
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;
    using Mpc.WinFormsIoC.Application.Services.Mappings;
    using Mpc.WinFormsIoC.Domain.Core;

    internal class CountryService : ICountryService
    {
        private IUnitOfWork _unitOfWork;

        public CountryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<CountryDto>> GetAllAsync()
        {
            var countries = await _unitOfWork.CountriesRepository.GetAllAsync().ConfigureAwait(false);

            return countries.ToDto().ToList();
        }
    }
}
