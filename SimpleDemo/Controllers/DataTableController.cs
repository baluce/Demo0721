using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleDemo.Controllers
{
    public class DataTableController : Controller
    {
        // GET: DataTable
        public ActionResult Test0()
        {
            return Redirect("~/DataTableTest0.html");
        }
    }
}