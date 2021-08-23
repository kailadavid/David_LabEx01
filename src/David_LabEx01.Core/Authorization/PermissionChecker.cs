using Abp.Authorization;
using David_LabEx01.Authorization.Roles;
using David_LabEx01.Authorization.Users;

namespace David_LabEx01.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
