using System.ComponentModel.DataAnnotations;

namespace GolfStore_L00181486.Pages.PageViewModels
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
