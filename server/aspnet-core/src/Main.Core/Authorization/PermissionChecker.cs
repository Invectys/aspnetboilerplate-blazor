using Abp.Authorization;
using Main.Authorization.Roles;
using Main.Authorization.Users;

namespace Main.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
