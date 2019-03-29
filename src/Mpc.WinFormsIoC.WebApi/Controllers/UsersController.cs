using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Users;

namespace Mpc.WinFormsIoC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UserDto>), 200)]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAsync()
        {
            var users = await _userService.GetAllAsync().ConfigureAwait(false);

            return users;
        }

        /// <summary>
        /// Get a user by Id
        /// </summary>
        /// <param name="id">User's identifier</param>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserDto), 200)]
        [ProducesResponseType(404)]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="user">User to create</param>
        [HttpPost]
        public void Post([FromBody] UserDto user)
        {
        }

        /// <summary>
        /// Edit a user
        /// </summary>
        /// <param name="id">User's identifier</param>
        /// <param name="updatedUser">New values of the user</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserDto updatedUser)
        {
        }

        /// <summary>
        /// Remove a user
        /// </summary>
        /// <param name="id">User's identifier</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
