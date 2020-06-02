using MobilePaywall.Direct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilePaywall.WebLogInspector.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult ViewDetails(int id, string tableName)
        {
            MobilePaywallDirect directInstance = MobilePaywallDirect.Instance;
            string sqlCommand = "SELECT * FROM MobilePaywall.log." + tableName + " WHERE " + tableName + "ID="+ id;
            DirectContainer conteiner = directInstance.LoadContainer(sqlCommand);
            WebLogInspector.Models.Home.LogResultModel model = new Models.Home.LogResultModel(conteiner.Rows.First());
            return View(model);
        }
    }
}