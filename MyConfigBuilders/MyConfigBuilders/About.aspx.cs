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
        public string Msg { get; set; }
        public string ServiceKey { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            Msg = ConfigurationManager.AppSettings["ServiceID"];
            ServiceKey = ConfigurationManager.AppSettings["ServiceKey"];
        }
    }
}