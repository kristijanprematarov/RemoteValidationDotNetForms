using RemoteValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidation.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentModel sm = new StudentModel();
            return View(sm);
        }

        [HttpGet]
        public JsonResult IsEmailExist(string Email)
        {
            bool isExist = false;
            if (Email.Equals("abc@gmail.com"))
            {
                isExist = true;
            }
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }
    }
}