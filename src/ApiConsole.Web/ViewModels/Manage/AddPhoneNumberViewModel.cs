using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ApiConsole.Web.ViewModels.Manage
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global",
        Justification = "ViewModel")]
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
