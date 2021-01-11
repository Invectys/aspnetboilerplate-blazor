using System.ComponentModel.DataAnnotations;

namespace Main.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}