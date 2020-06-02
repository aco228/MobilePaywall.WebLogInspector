using MobilePaywall.Direct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobilePaywall.WebLogInspector.Models.Home
{
  public class HomeModel
  {
    private List<LogResultModel> _rowsList = null;

    public List<LogResultModel> RowsList { get { return this._rowsList; } }

    public HomeModel(DirectContainer container)
    {
      LogResultModel logModel = null;
      this._rowsList = new List<LogResultModel>();
      foreach(DirectContainerRow row in container.Rows)
      {
        logModel = new LogResultModel(row);
        this._rowsList.Add(logModel);
      }
    }
  }
}