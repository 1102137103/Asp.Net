using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _0314.Controllers
{
    public class OrderController : Controller
    {
       public ActionResult Index()
        {
            eSaleService.OrderService orderService = new eSaleService.OrderService();
            ViewBag.data = orderService.GetOrderById("1");
            
            return View();
        }
        /// <summary>
        /// 新增訂單的畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder()
        {
            Models.Order order = new Models.Order();
            order.CustName="叡揚資訊";
            return View();
        }
        /// <summary>
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            ViewBag.Desc1 = "我是ViewBag";
            ViewData["Desc2"] = "我是ViewData";
            TempData["Desc3"] = "我是TempData";
            
            return RedirectToAction("Index");
        }
        [HttpGet()]
        public JsonResult TestJson()
        {
            //var result = new Models.Order();
            //result.CustId = "Gss";
            //result.CustName = "Alina";
            var result = new Models.Order() { CustId = "Gss", CustName = "Alina" };
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}