using mvcservicedemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcservicedemo.Controllers
{
    public class ServiceController : Controller
    {
        private Repository repo = new Repository();

        [Route("~/api/getfinancialdata")]
        [HttpGet]
        public ActionResult GetData()
        {
            return Json(repo.GetFinancialData(), JsonRequestBehavior.AllowGet);
        }

        [Route("~/api/financialdata")]
        [HttpGet]
        public ActionResult SetData(int markedsvardi)
        {
            repo.GetFinancialData().markedsvardi = markedsvardi;
            return Json(repo.GetFinancialData(), JsonRequestBehavior.AllowGet);
        }

        [Route("~/api/getaccounts")]
        [HttpGet]
        public ActionResult GetAccounts()
        {
            var rep = new Repository();
            return Json(rep.GetAllAccounts(), JsonRequestBehavior.AllowGet);
        }

        [Route("~/api/getaccount")]
        [HttpGet]
        public ActionResult GetAccount(int id)
        {
            var rep = new Repository();
            return Json(rep.GetAccount(id), JsonRequestBehavior.AllowGet);
        }

        [Route("~/api/getspecialaccount")]
        [HttpGet]
        public ActionResult GetSpecialAccount(int id, string field)
        {
            var rep = new Repository();
            return Json(rep.GetAccount(id), JsonRequestBehavior.AllowGet);
        }
    }
}