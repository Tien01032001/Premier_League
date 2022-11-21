using Abp.Authorization;
using CSDL.Authorization.Roles;
using CSDL.Authorization.Users;

namespace CSDL.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
