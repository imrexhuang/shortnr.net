using Elmah;
using Shortnr.Web.Filters;
using System.Web;
using System.Web.Mvc;

namespace Shortnr.Web
{
	public class FilterConfig
	{
        //https://blog.miniasp.com/post/2013/03/12/ASPNET-MVC-4-and-ELMAH-Integration
        public class ElmahHandledErrorLoggerFilter : IExceptionFilter
	    {
	        public void OnException(ExceptionContext context)
	        {
	            if (context.ExceptionHandled)
	                ErrorSignal.FromCurrentContext().Raise(context.Exception);
	        }
	    }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new ShortnrErrorFilter());
		    filters.Add(new ElmahHandledErrorLoggerFilter());
		    filters.Add(new HandleErrorAttribute());

        }
	}
}
