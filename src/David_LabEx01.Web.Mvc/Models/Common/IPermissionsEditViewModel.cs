using System.Collections.Generic;
using David_LabEx01.Roles.Dto;

namespace David_LabEx01.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}