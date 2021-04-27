using System.ComponentModel.DataAnnotations;

namespace Divisima.ViewModels.Account
{
    public class LoginViewModel: AbstractAccountViewModel
    {
        
        public string ReturnUrl { get; set; }
    }
}