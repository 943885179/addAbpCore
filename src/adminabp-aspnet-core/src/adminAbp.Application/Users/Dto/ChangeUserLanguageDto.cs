using System.ComponentModel.DataAnnotations;

namespace adminAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}