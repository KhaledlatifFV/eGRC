using Microsoft.AspNetCore.Identity;

namespace ISMS.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public byte[]? ProfilePicture { get; set; }

    }
}
