using System.ComponentModel.DataAnnotations;

namespace ClinicNB.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}