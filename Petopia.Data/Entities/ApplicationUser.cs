using Microsoft.AspNetCore.Identity;
using Petopia.Data.Enums;

namespace Petopia.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public GenderEnum Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public byte[] ProfileImage { get; set; } = new byte[0];
        public byte[] Cover { get; set; } = new byte[0];
        public bool blocked { get; set; } = false;
    }

}
