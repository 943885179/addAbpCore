using Abp.Authorization;
using adminAbp.Authorization.Roles;
using adminAbp.Authorization.Users;

namespace adminAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
