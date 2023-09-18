using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.DataAccess.Repositories;
using CRM.Core.Dto;
using CRM.Core.Models;

namespace CRM.Application.Services
{
    public class UserService
    {
        private readonly UserRespository _userRepository;

        public UserService(IConfiguration configuration)
        {
            _userRepository = new UserRespository(configuration);
        }

        public async Task<List<UserDto>> GetUsers()
        {
            List<UserDto> result = new List<UserDto>();
            var response = await _userRepository.GetUsers();


            //if (sortedFields.Count == 0)
            //{
            //    await _fieldSettingRepository.CreateMany(SetupSystemFields(userId));
            //    sortedFields = await _fieldSettingRepository.GetSortedFields(userId, status);
            //}
            result = MapToUserView(response);
            return result;
        }

        private List<UserDto> MapToUserView(List<User> response)
        {
            List<UserDto> result = new List<UserDto>();

            result = response.Select(c => new UserDto
            {
                Id = c.Id,
                UserName = c.UserName,
                Email = c.Email,   
                Phone = c.Phone,
                Skills = c.Skills,
                Hobbies = c.Hobbies                
            }).ToList();

            return result;
        }


        public async Task<UserDto> GetUserById(string id)
        {
            List<User> responses = new List<User>();

            var response = await _userRepository.GetUserById(id);
            responses.Add(response);
            var result = MapToUserView(responses);
            return result.First();
        }

        public async Task CreateUser(UserDto input)
        {
            await _userRepository.CreateUser(input);
        }
        

        public async Task UpdateUser(UserDto input)
        {
            await _userRepository.UpdateUser(input);
        }

        public async Task DeleteUserById(string id)
        {
            await _userRepository.DeleteUserById(id);
        }



    }
}
