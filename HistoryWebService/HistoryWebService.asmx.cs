using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HistoryWebService
{
    /// <summary>
    /// Summary description for HistoryWebService
    /// Author: Suman Basyal
    /// Created Date: 10/7/2017
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HistoryWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public int AddToFile(int month, int day, string events)
        {
            HistoryEntities entites = new HistoryEntities();
            HistoryPage page = new HistoryPage() { month = month, day = day, events = events };
            entites.HistoryPages.Add(page);
            int ren=entites.SaveChanges();
            return ren;
        }

        [WebMethod]
        public List<HistoryPage> GetFromFile(int month, int day)
        {
            HistoryEntities entites = new HistoryEntities();
            List<HistoryPage> list=entites.HistoryPages.Where(x => x.day == day && x.month == month).ToList();
            return list;
        }
    }
}
