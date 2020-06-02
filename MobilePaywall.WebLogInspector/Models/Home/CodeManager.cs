using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobilePaywall.Direct;

namespace MobilePaywall.WebLogInspector.Models.Home
{
  public class CodeManager
  {
    private DirectContainer _conteiner;
    private string _sqlCommand;
    private HomeModel _homeModel;

    public DirectContainer Conteiner { get { return this._conteiner; } }
    public HomeModel HomeModels { get { return this._homeModel; } }

    public CodeManager(FilterModel filter)
    {
      MobilePaywallDirect directInstance = MobilePaywallDirect.Instance;

      CreateSql(filter);
      this._conteiner = directInstance.LoadContainer(_sqlCommand);
      _homeModel = new HomeModel(this._conteiner);
    }

    private void CreateSql(FilterModel filter)
    {
      this._sqlCommand = "SELECT TOP " + (filter.Top == ""? "50": filter.Top) + " * FROM MobilePaywall.log." + filter.Table + " WHERE (" 
                         + " (" + DateSelector(filter.From, filter.To) + ") AND "
                         + " ('" + filter.Level + "'= '' OR Level LIKE '%" + filter.Level + "%') AND "
                         + " ('" + filter.Keyword + "'= '' OR Message LIKE '%" + filter.Keyword + "%') "
                         + " )"
                         + " ORDER BY " + filter.Table + "ID DESC";

    }

    private string DateSelector(string from, string to)
    {
      if (from == "" || to == "")
        return "''=''";

      string returnStr = "Date BETWEEN '" + from + "' AND '" + to + "'";


      return returnStr;
    }
  }
}