using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobilePaywall.WebLogInspector.Models.Home
{
  public class FilterModel
  {
    private string _table = "";
    private string _top = "";
    private string _from = "";
    private string _to = "";
    private string _level = "";
    private string _keyword = "";

    public string Table { get { return this._table; } }
    public string Top { get { return this._top; } }
    public string From { get { return this._from; } }
    public string To { get { return this._to; } }
    public string Level { get { return this._level; } }
    public string Keyword { get { return this._keyword; } }

    public FilterModel(string table, string top, string from, string to, string level, string keyword)
    {
      this._table = table;
      this._top = top;
      this._from = from;
      this._to = to;
      this._level = level;
      this._keyword = keyword;
    }
  }
}