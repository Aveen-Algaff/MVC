using DAL.ConnectionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShopOnesie.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            ProductLayer log = new ProductLayer();
            if (log.logIn(txtUserName.Text,txtPassword.Text)==true)
            {
                //HttpCookie c = new HttpCookie("login");
                Session["login"]= txtUserName.Text;
               
                if (ChkRemember.Checked)
                {
                    //Session["login"]
                }
                
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                lbllogin.Text = "User/Password incorrect";
            }
        }
    }
}