using Abp.Application.Services.Dto;

namespace David_LabEx01.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

