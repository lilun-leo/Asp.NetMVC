using Commom;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {

            string url = "http://localhost:12720/api/UserInfo?id=1";
            var a = HttpRequestHelper.HttpResponseGetString(url);

            var model = JsonConvert.DeserializeObject<Entity.UserInfo>(a);
            return View(model);
        }
    }
}