using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Core.Dto;

namespace CRM.Application.Services.Interfaces
{
    public interface IUserService
    {

        /// <summary>
        /// Get users info
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<UserDto>> GetUsers();

        /// <summary>
        /// Get user info
        /// </summary>
        /// <returns></returns>
        Task<UserDto> GetUser();

        /// <summary>
        /// Create new user
        /// </summary>
        /// <returns></returns>
        Task CreateUser(UserDto input);

        /// <summary>
        /// Delete user by id
        /// </summary>
        /// <returns></returns>
        Task DeleteUserById(string id);

        /// <summary>
        /// Update user
        /// </summary>
        /// <returns></returns>
        Task UpdateUser(UserDto input);

    }
}
