using MXM.BLL;
using MXM.Entity.Domain;
using MXMCommon.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MXM.Web.Areas.fjpc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// 添加留言内容
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddMessageBoard(FormCollection form)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { Success = true, ErrorMessage = "留言失败，请稍后重试！" }, JsonRequestBehavior.DenyGet);
            }
            try
            {
                var host = HttpUtility.UrlDecode(HttpContext.Request.Url.Host.ToString() ?? string.Empty);
                var requestUrl = HttpUtility.UrlDecode(HttpContext.Request.Url.ToString() ?? string.Empty);
                var urlReferrer = HttpUtility.UrlDecode(HttpContext.Request.UrlReferrer.ToString());
                var userName = HttpUtility.UrlDecode(form["UserName"].ToString() ?? string.Empty);
                var phone = HttpUtility.UrlDecode(form["Phone"].ToString() ?? string.Empty);
                var messageContent = HttpUtility.UrlDecode(form["Comment"].ToString() ?? string.Empty);
                var IsPhone = System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[1]+\d{10}");
                if (string.IsNullOrEmpty(userName))
                {
                    return Json(new { Success = false, ErrorMessage = "姓名不能为空！" }, JsonRequestBehavior.DenyGet);
                }
                if (string.IsNullOrEmpty(phone) || !IsPhone)
                {
                    return Json(new { Success = false, ErrorMessage = "手机号码有误，请重新填写！" }, JsonRequestBehavior.DenyGet);
                }
                var entity = new MessageBoard
                {
                    UserName = HttpUtility.UrlDecode(userName.Trim()),
                    Phone = HttpUtility.UrlDecode(phone.Trim()),
                    MessageContent = HttpUtility.UrlDecode(messageContent.Trim()),
                    ClientIp = IPAddressHelper.GetClientIp(),
                    LocalIp = IPAddressHelper.GetLocalIp(),
                    RequestUrl = requestUrl,
                    UrlReferrer = urlReferrer,
                    Host = host,
                    CreateTime = DateTime.Now
                };
                var messageBoard = new MessageBoardBll();
                messageBoard.Add(entity);
                return Json(new { Success = true, }, JsonRequestBehavior.DenyGet);
            }
            catch
            {
                return Json(new { Success = false, ErrorMessage = "留言失败，请稍后重试！" }, JsonRequestBehavior.DenyGet);
            }
        }
    }
}