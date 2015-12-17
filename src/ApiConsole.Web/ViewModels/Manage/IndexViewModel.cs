using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNet.Identity;

namespace ApiConsole.Web.ViewModels.Manage
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global",
        Justification = "ViewModel")]
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        public string PhoneNumber { get; set; }

        public bool TwoFactor { get; set; }

        public bool BrowserRemembered { get; set; }
    }
}
