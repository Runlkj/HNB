using Abp.Authorization;
using ClinicNB.Authorization.Roles;
using ClinicNB.Authorization.Users;

namespace ClinicNB.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
