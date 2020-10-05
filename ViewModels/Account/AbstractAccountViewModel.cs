using System.ComponentModel.DataAnnotations;

namespace Divisima.ViewModels.Account
{
    public abstract class AbstractAccountViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}