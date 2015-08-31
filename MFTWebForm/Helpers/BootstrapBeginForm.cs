using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MFTWebForm.Helpers
{
    public static class BootstrapBeginForm
    {
        public static MvcForm BeginFormCol(this HtmlHelper helper)
        {
            return helper.BeginForm(null, null, FormMethod.Post, new { @class = "col-md-12" });
        }
    }
}