namespace Mpc.WinFormsIoC.Application.Services.Mappings
{
    using System.Collections.Generic;
    using System.Linq;
    using Mpc.WinFormsIoC.Application.Dto;
    using Mpc.WinFormsIoC.Domain.Models;

    public static class UserMapping
    {
        /// <summary>
        /// Text used to hide the encrypted password
        /// </summary>
        private static readonly string hidePassword = "***************";

        /// <summary>
        /// Convert IEnumerable of UserModel to IEnumerable of UserDto 
        /// </summary>
        public static IEnumerable<UserDto> ToDto(this IEnumerable<UserModel> users)
        {
            return users?.Select(ToDto);
        }

        /// <summary>
        /// Convert Model to Dto
        /// </summary>
        public static UserDto ToDto(this UserModel user)
        {
            return user == null ? null : new UserDto
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                Password = hidePassword,
                Username = user.Username
            };
        }

        /// <summary>
        /// Convert IEnumerable of UserDto to IEnumerable of UserModel 
        /// </summary>
        public static IEnumerable<UserModel> ToModel(this IEnumerable<UserDto> users)
        {
            return users?.Select(ToModel);
        }

        /// <summary>
        /// Convert Dto to Model
        /// </summary>
        public static UserModel ToModel(this UserDto user)
        {
            return user == null ? null : new UserModel
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                Password = user.Password == hidePassword ? string.Empty : user.Password,
                Username = user.Username
            };
        }
    }
}
