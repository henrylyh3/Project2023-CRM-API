using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CRM.Core.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("UserName")]
        public string UserName { get; set; } = null!;

        [BsonElement("Email")]
        public string Email { get; set; } = null!;
        
        [BsonElement("Phone")]
        public string Phone { get; set; } = null!;
        
        [BsonElement("Skills")]
        public string Skills { get; set; } = null!;
        
        [BsonElement("Hobbies")]
        public string Hobbies { get; set; } = null!;
        [BsonElement("CreatedOn")]
        public DateTime CreatedOn { get; set; }
        [BsonElement("UpdatedOn")]
        public DateTime UpdatedOn { get; set; }

    }
}
