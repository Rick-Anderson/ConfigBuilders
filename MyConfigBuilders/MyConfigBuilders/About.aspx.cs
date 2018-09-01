using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyConfigBuilders
{
    public partial class About : Page
    {
        public string ServiceID { get; set; }
        public string ServiceKey { get; set; }
        public string ConString { get; set; }



        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceID = ConfigurationManager.AppSettings["ServiceID"];
            ServiceKey = ConfigurationManager.AppSettings["ServiceKey"];
            ConString = ConfigurationManager.AppSettings["Default"];

        }
    }
}