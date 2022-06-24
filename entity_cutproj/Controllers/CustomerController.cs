using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using entity_cutproj.DataAcess;
using entity_cutproj.Models;

namespace entity_cutproj.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Load()
        {
            customer csobj = new customer();
            
            return View("loadcustomer",csobj);
        }
        public ActionResult Enter()
        {
            return View("Entercustomer");
        }
        public ActionResult submit(customer obj)
        {
            if(ModelState.IsValid)
            {
                //insert customer object to db
                custdal dal=new custdal();
                dal.Customers.Add(obj);
                dal.SaveChanges();
                return View("LoadCustomer", obj);
            }
            else
            {
                return View("Entercustomer",obj);
            }

            
        }
    }
}