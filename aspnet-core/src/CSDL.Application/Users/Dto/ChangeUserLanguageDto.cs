using System.ComponentModel.DataAnnotations;

namespace CSDL.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}