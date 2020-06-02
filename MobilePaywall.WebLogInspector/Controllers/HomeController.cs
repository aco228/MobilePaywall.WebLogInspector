using MobilePaywall.WebLogInspector.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilePaywall.WebLogInspector.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult FilterTable(string table, string top, string from, string to, string level, string keyword)
    {
      FilterModel model = new FilterModel(table, top, from, to, level, keyword);

      CodeManager sqlModel = new CodeManager(model);

      return PartialView("~/Views/Home/_Partial/_Logs.cshtml", sqlModel.HomeModels);
    }

  }
}