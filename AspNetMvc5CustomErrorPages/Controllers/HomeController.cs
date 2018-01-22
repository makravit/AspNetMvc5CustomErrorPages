using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc5CustomErrorPages.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ReturnHttpNotFoundResult()
        {
            return HttpNotFound();
        }

        public ActionResult ReturnHttpStatusCodeResult404()
        {
            return new HttpStatusCodeResult(HttpStatusCode.NotFound);
        }

        public ActionResult ThrowHttpException404()
        {
            throw new HttpException((int)HttpStatusCode.NotFound, "Not found");
        }

        public ActionResult ReturnHttpStatusCodeResult500()
        {
            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
        }
        public ActionResult ThrowException()
        {
            throw new Exception();
        }
    }
}