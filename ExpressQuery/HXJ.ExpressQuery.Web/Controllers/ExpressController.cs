using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HXJ.ExpressQuery.Web.Controllers
{
    public class ExpressController : Controller
    {
        //
        // GET: /Express/

        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 调用API
        /// </summary>
        /// <returns></returns>
        public ActionResult ExpressSendMsg()
        {
            return View();
        }
    }
}
