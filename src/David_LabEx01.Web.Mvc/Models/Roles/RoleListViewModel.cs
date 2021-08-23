using System.Collections.Generic;
using David_LabEx01.Roles.Dto;

namespace David_LabEx01.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
