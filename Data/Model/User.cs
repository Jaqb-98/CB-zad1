using Microsoft.AspNetCore.Identity;

namespace BlazorUsersRoles.Data.Model
{
    public class User: IdentityUser
    {
        public int PasswordValidityInDays { get; set; }
        public bool IsNew { get; set; }
    }
}
