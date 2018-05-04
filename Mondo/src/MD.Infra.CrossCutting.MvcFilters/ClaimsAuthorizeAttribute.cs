using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using System.Security.Claims;
using System.Net;

namespace MD.Infra.CrossCutting.MvcFilters
{
    public class ClaimsAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly string _claimName;
        private readonly string _claimValue;

        public ClaimsAuthorizeAttribute(string pstClaimName, string pstClaimValue)
        {
            _claimName = pstClaimName;
            _claimValue = pstClaimValue;
        }

        // Override na verificação de permissão do Identity
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var identity = (ClaimsIdentity)httpContext.User.Identity;
            var claim = identity.Claims.FirstOrDefault(c => c.Type == _claimName);
            return claim != null && claim.Value.Contains(_claimValue);
        }

        // Tratamento para acesso negado
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAuthenticated)
                filterContext.Result = new HttpStatusCodeResult((int)HttpStatusCode.Forbidden);
            else
                base.HandleUnauthorizedRequest(filterContext);
        }
    }
}
