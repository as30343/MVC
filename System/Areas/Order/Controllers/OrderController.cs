using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System.Areas.Order.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/Order/
        /// <summary>
        /// 訂單管理系統_首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 訂單管理系統_查詢
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowResult()
        {
            return View();
        }
        /// <summary>
        /// 訂單管理系統_查詢細項
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowDetail()
        {
            return View();
        }

        /// <summary>
        /// 訂單管理系統_新增畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder()
        {
            return View();
        }
        /// <summary>
        /// 訂單管理系統_修改
        /// </summary>
        /// <returns></returns>
        public ActionResult UpdateOrder()
        {
            return View();
        }
        /// <summary>
        /// 訂單管理系統_刪除
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteOrder()
        {
            return View();
        }
	}
}