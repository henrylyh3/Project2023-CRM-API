using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using CRM.Core.Models;
using CRM.Core.Dto;

namespace CRM.DataAccess.Repositories
{
    public class UserRespository : MongoDBClient
    {
        private readonly IMongoCollection<User> _usersCollection;

        public UserRespository(IConfiguration configuration) : base(configuration)
        {
            _usersCollection = MongoDb.GetCollection<User>("users");
        }

        public async Task<List<User>> GetUsers()
        {
            var filter = Builders<User>.Filter.Empty;
            var sort = Builders<User>.Sort.Descending("_id");

            return await _usersCollection.Find(filter).Sort(sort).ToListAsync();
        }

        public async Task<User> GetUserById(string id)
        {
            var filter = Builders<User>.Filter.Empty;
            filter &= Builders<User>.Filter.Eq("Id", id);

            return await _usersCollection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task CreateUser(UserDto input)
        {
            var record = new User();

            record.UserName = input.UserName;
            record.Email = input.Email;
            record.Phone = input.Phone;
            record.Skills = input.Skills;
            record.Hobbies = input.Hobbies;
            record.CreatedOn = DateTime.Now;
            record.UpdatedOn = DateTime.Now;


            await _usersCollection.InsertOneAsync(record);
        }
        
        public async Task UpdateUser(UserDto input)
        {
            var filter = Builders<User>.Filter.Empty;
            filter &= Builders<User>.Filter.Eq("Id", input.Id);

            var update = Builders<User>.Update
                .Set("UserName", input.UserName)
                .Set("Email", input.Email)
                .Set("Phone", input.Phone)
                .Set("Skills", input.Skills)
                .Set("Hobbies", input.Hobbies)
                .Set("UpdatedOn", DateTime.Now);

            await _usersCollection.UpdateOneAsync(filter, update);
        }
        
        public async Task DeleteUserById(string id)
        {
            var filter = Builders<User>.Filter.Empty;
            filter &= Builders<User>.Filter.Eq("Id", id);

            await _usersCollection.DeleteOneAsync(filter);
        }

    }
}
