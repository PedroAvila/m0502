using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static MvcHtmlString DataGridFor(this HtmlHelper helper, IEnumerable items)
        {
            var sb = new StringBuilder();
            if (items != null)
            {
                sb.Append("<table class=\"DataGrid\">");
                string[] propertyNames = null;
                bool alt = false;
                foreach (var item in items)
                {
                    if (propertyNames == null)
                    {
                        propertyNames = item.GetType().GetProperties().Where(p => !p.PropertyType.IsClass || p.PropertyType == typeof(string)).Select(p => p.Name).ToArray();
                        sb.Append("<tr>");
                        foreach (var e in propertyNames)
                        {
                            string displayName = ModelMetadataProviders.Current.GetMetadataForProperty(null, item.GetType(), e).DisplayName;
                            displayName = displayName ?? e;
                            sb.AppendFormat("<th>{0}</th>", displayName);
                        }
                        sb.Append("</tr>");
                    }
                    sb.AppendFormat("<tr {0}>", alt ? "class=\"alt\"" : "");
                    foreach (var p in propertyNames)
                    {
                        sb.AppendFormat("<td>{0}</td>", item.GetType().GetProperty(p).GetValue(item));
                    }
                    sb.Append("</tr>");
                    alt = !alt;
                }
                sb.Append("</table>");
            }
            return new MvcHtmlString(sb.ToString());
        }
    }
}