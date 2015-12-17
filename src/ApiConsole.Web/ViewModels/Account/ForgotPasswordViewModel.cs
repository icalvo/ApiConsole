using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ApiConsole.Web.ViewModels.Account
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global",
        Justification = "ViewModel")]
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
