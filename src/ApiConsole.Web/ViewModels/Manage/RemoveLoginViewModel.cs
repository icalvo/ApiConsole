using System.Diagnostics.CodeAnalysis;

namespace ApiConsole.Web.ViewModels.Manage
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global",
        Justification = "ViewModel")]
    public class RemoveLoginViewModel
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
    }
}
