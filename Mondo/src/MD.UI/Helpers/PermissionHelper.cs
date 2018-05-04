using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace MD.UI.Helpers
{
    public static class PermissionHelper
    {
        private static bool ValidadePermission(string pstClaimName, string pstClaimValue)
        {
            var identity = (ClaimsIdentity)HttpContext.Current.User.Identity;
            var claim = identity.Claims.FirstOrDefault(c => c.Type == pstClaimName);
            return claim != null && claim.Value.Contains(pstClaimValue);
        }

        public static MvcHtmlString IfClaimhelper(this MvcHtmlString value, string pstClaimName, string pstClaimValue)
        {
            return ValidadePermission(pstClaimName, pstClaimValue) ? value : MvcHtmlString.Empty;
        }

        public static bool IfClaim(this WebViewPage page, string pstClaimName, string pstClaimValue)
        {
            return ValidadePermission(pstClaimName, pstClaimValue);
        }
        
    }
}