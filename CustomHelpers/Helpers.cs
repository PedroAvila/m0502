using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M0502.CustomHelpers
{
    public static class Helpers
    {
        public static MvcHtmlString CurrenTime(this HtmlHelper helper)
        {
            return new MvcHtmlString(DateTime.Now.ToShortTimeString());
        }
    }
}