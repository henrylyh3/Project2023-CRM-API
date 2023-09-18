
namespace CRM.Core.Dto
{
    public class UserDto
    {
        public string? Id { get; set; }
        //public long UserId { get; set; }
        public string? UserName { get; set; } = null;
        public string? Email { get; set; } = null;
        public string? Phone { get; set; } = null;
        public string? Skills { get; set; } = null;
        public string? Hobbies { get; set; } = null;
    }
}
