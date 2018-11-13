using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Domain.Core;

namespace Mpc.WinFormsIoC.Application.Services.Countries
{
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

            var countriesDto = countries.Select(x => new CountryDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return countriesDto;
        }
    }
}
