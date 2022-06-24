using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using entity_cutproj.DataAcess;
using entity_cutproj.Models;
using entity_cutproj.ViewModel;

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
            custViewModel obj = new custViewModel();
            //emty customer object for first time binding
            obj.customerobj = new customer();
            custdal dal = new custdal();
            List<customer> custcoll = dal.Customers.ToList<customer>();
            obj.customers = custcoll;

            return View("Entercustomer",obj);
        }
        public ActionResult submit(custViewModel obj)
        {
            custViewModel vm = new custViewModel();
            customer obj1 = new customer();
            obj1.custcode = Request.Form["customerobj.custcode"];
            obj1.custname = Request.Form["customerobj.custname"];

            if(ModelState.IsValid)
            {
                
                //insert customer object to db
                custdal Dal=new custdal();
                Dal.Customers.Add(obj.customerobj);
                Dal.SaveChanges();
                vm.customerobj=new customer();
               
            }
           // return View("LoadCustomer", obj);
            else
            {
                vm.customerobj = obj1;
            }

            custdal dal = new custdal();
            List<customer> custcoll = dal.Customers.ToList<customer>();
            vm.customers = custcoll;
            return View("Entercustomer", vm);
           

        }
    }
}