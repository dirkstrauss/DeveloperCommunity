using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DebugClientSide
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindCities();            
        }

        private void BindCities()
        {
            ddlCities.Items.Add(new ListItem("Select City", "0"));
            ddlCities.Items.Add(new ListItem("Amsterdam", "1"));
            ddlCities.Items.Add(new ListItem("London", "2"));
            ddlCities.Items.Add(new ListItem("Paris", "3"));
            ddlCities.Items.Add(new ListItem("Washington", "4"));

        }
    }
}