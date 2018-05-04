using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MD.Infra.CrossCutting.MvcFilters
{
    public class GlobalErrorHandler : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // Log Auditoria

            if(filterContext.Exception != null)
            {
                // Manipular a EX
                // Injetar alguma lib de tratamento de erro:
                //  -> Gravar Log do erro no BD
                // -> E-mail para o admin
                // -> Retornar cod de erro amigável

                // Sempre ASYNC

            }

            base.OnActionExecuted(filterContext);
        }

    }
}
