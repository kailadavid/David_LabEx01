using System.Collections.Generic;
using System.Linq;
using David_LabEx01.Roles.Dto;
using David_LabEx01.Users.Dto;

namespace David_LabEx01.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
