using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProj.Models;

namespace TestProj.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? page)
        {
            int pageSize = 2;
            int pageIndex = 1;
            Employee employee = new Employee();
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            IPagedList emps = null;
            emps = employee.List().ToPagedList(pageIndex, pageSize);

            return View(emps);
        }
    }
}