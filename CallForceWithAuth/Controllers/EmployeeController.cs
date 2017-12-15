using CallForceWithAuth.DAL;
using CallForceWithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallForceWithAuth.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private CallForceContext db = new CallForceContext();


        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.empID = new SelectList(db.Employees, "empID", "empName");

            return View();
        }

        [HttpGet]
        public ViewResult EmpChosen(int? empID)
        {

            Employee employee = db.Employees.Find(empID);



            return View("Goals", employee);
        }

        public ActionResult Goals()
        {
            return View();
        }
        public ActionResult TeamMessage()
        {
            ViewBag.email = TempData["email"];
            return View(db.MessageBoards.ToList());
        }

        [HttpPost]
        public ActionResult TeamMessage(FormCollection form)
        {
            var messageId = form["messageId"];
            MessageBoard MB = db.MessageBoards.Find(messageId);
            if(MB != null)
            {
                if (form["comment"].Length > 1)
                {
                    MB.answer = form["comment"];
                    MB.userID = form["userId"];
                }
            }
            
            return View();
        }
    }
}