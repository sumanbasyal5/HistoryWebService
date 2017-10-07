using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryWebService
{
    public class HistoryModel
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public string events { get; set; }
    }
}