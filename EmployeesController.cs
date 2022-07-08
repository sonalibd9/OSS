using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRMWebApp.Models;

namespace CRMWebApp.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees

        //http://localhost:61541/employees/index
       [HttpGet]
        public ActionResult Index()
        {
            List<Employee> employees = HRManager.GetAll();
            return View(employees);
        }

        //http://localhost:61541/employees/
        //http://localhost:61541/employees/Details
        public ActionResult Details(int id)
        {
           Employee employees = HRManager.GetByID(id);
            return View(employees);
        }


        //http://localhost:61541/employees/Delete
        public ActionResult Delete(int id)
        {
            bool status = HRManager.Delete(id);
            if (status)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //http://localhost:61541/employees/insert
        public ActionResult Insert()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Insert(int id,string firstname,string lastname,string email,string department,string location,string contactnumber)
        {
            Employee emp = new Employee
            {
                ID = id,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Department = department,
                Location = location,
                ContactNumber = contactnumber
            };
            HRManager.Insert(emp);

            return RedirectToAction("index");
        }

        public ActionResult Update(int id)
        {
            Employee employee = HRManager.GetByID(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Update(int id, string firstname, string lastname, string email, string department, string location, string contactnumber)
        {
            Employee emp = new Employee
            {
                ID = id,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Department = department,
                Location = location,
                ContactNumber = contactnumber
            };
            HRManager.Update(emp);

            return RedirectToAction("index");
        }
    }
}