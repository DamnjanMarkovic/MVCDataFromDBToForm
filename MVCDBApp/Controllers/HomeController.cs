using MVCDBApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using DataLibrary.BusinessLogic;

namespace MVCDBApp.Controllers
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
        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employees list";
            var data = EmployeeProcessor.LoadEmployees();

            List<EmployeeModel> employess = new List<EmployeeModel>();
            foreach (var row in data) 
            {
                employess.Add(new EmployeeModel
                {
                    EmployeeId = row.EmployeeID,
                    Firstname = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress,
                    ConfirmEmail = row.EmailAddress
                });

            }


            return View(employess);
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee SignUp.";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Employee details.";

            return View();
        }

        public ActionResult Delete()
        {
            ViewBag.Message = "Employee delete.";

            return View();
        }




        public ActionResult Edit()
        {
            ViewBag.Message = "Edit";
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {

                int recordsCreated = EmployeeProcessor.CreateEmployee(model.EmployeeId, model.Firstname, model.LastName, model.EmailAddress);



                return RedirectToAction("Index");
            }

            return View();
        }
    }
}