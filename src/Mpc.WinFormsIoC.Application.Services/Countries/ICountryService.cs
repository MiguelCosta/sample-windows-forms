namespace Mpc.WinFormsIoC.Application.Services.Countries
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;

    public interface ICountryService
    {
        Task<List<CountryDto>> GetAllAsync();
    }
}
