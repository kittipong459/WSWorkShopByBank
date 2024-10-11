using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSTD.Controllers
{
    public class cHomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            StringBuilder oSb = new StringBuilder();
            oSb.AppendLine($"");
            oSb.AppendLine($"<h1>{Assembly.GetExecutingAssembly().GetName().Name} v{Assembly.GetEntryAssembly().GetName().Version}</h1>");

            return new ContentResult
            {
                ContentType = "text/html",
                Content = oSb.ToString()
            };
        }
    }
}
