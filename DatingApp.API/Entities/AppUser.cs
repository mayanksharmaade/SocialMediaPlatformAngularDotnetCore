using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Entities
{
    public class AppUser
    {
        [Required]
        public  Int32 ID { get; set; }
        public required string UserName { get; set; }
    }
}
