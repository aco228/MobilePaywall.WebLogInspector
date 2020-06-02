using MobilePaywall.Direct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePaywall.WebLogInspector.Models.Home
{
  public class LogResultModel
  {
    private DirectContainerRow _containerRow;
    public string ID { get { return this._containerRow[0].ToString(); } }
    public string Level { get { return this._containerRow.GetString("Level"); } }
    public string Logger { get { return this._containerRow.GetString("Logger"); } }
    public string Thread { get { return this._containerRow.GetString("Thread"); } }
    public string Messsage { get { return this._containerRow.GetString("Message"); } }
    public string Exception { get { return this._containerRow.GetString("Exception"); } }
    public string Method { get { return this._containerRow.GetString("Method"); } }
    public string Line { get { return this._containerRow.GetString("Line"); } }
    public string Date { get { return this._containerRow.GetString("Date"); } }
    public string DateDifference { get {
        DateTime happened = Convert.ToDateTime(this._containerRow.GetString("Date"));
        TimeSpan difference = DateTime.Now.Subtract(happened);
        return (int)difference.TotalHours + ":" + difference.Minutes.ToString();
      } }

    public LogResultModel(DirectContainerRow row)
    {
      this._containerRow = row;
    }

  }
}
