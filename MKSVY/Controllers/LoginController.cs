using MKSVY.Models;
using MKSVY.Servies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKSVY.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login objUser)
        {
            if (ModelState.IsValid)
            {
                List<Login> login1 = new List<Login>();
                login1 = LoginServices.GetLoginDetails(objUser.LOGIN_ID,objUser.PASSWORD);
                //using (LoginServices db = new DB_Entities())
                //{
                    var obj = login1.Where(a => a.LOGIN_ID.Equals(objUser.LOGIN_ID) && a.PASSWORD.Equals(objUser.PASSWORD)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.LOGIN_ID.ToString();
                        Session["Password"] = obj.PASSWORD.ToString();
                        return RedirectToAction("DistrictswiseSummary", "DashBoard");
                    }
                //}
            }
            return View(objUser);
        }
    }
}