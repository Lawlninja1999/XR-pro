using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XR_pro.Models
{
    public class Calendar
    {
        public int CalendarID { set; get; }
        public int startDay { get; set; }
        public int endDay { get; set; }
    }
}