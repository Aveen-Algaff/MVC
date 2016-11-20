using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShopOnesie
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"]!=null)
            {
                lblUser.Text = "Welcome Back: "+ Session["login"].ToString();
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                lblUser.Text = null;
            }
            //if (Request.Cookies["login"] != null)
            //{
            //    YourTabcontainerID.Tabs[1].Visible = false;
            //    //Your Login/logout Link Logic goes here
            //}
            //else
            //    YourTabcontainerID.Tabs[1].Visible = true;
        }
    }
}