using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        //GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginAction( string username, string pwd)
        {
            if("admin".Equals(username) && "123456".Equals(pwd))
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
    }
}