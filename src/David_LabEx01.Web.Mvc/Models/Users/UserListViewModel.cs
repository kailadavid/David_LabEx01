using System.Collections.Generic;
using David_LabEx01.Roles.Dto;

namespace David_LabEx01.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
