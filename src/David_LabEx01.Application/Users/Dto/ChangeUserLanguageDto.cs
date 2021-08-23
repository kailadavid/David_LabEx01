using System.ComponentModel.DataAnnotations;

namespace David_LabEx01.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}