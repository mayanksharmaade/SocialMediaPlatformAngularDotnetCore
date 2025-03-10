using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Entities
{
    public class AppUser
    {
        [Required]
        public  Int32 ID { get; set; }

        public required string UserName { get; set; }

         public required string FirstName { get; set; }

         public required string LastName { get; set; }

         public required string EmailId { get; set; }

         public required Boolean IsActive { get; set; }

         public required byte[] PasswordHash { get; set; }

        public required byte[] PasswordStamp { get; set; }
         
        public required DateTime CreatedOn { get; set; }

        public required DateTime LastSignIn { get; set; }

    }
}
