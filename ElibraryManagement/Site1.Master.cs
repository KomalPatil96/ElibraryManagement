using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {              

            if (Session["role"]==null)
            {
                LinkButton2.Visible = true;   //user login btn
                LinkButton3.Visible = true;   //Sign up
                LinkButton4.Visible = false;    //logout
                LinkButton5.Visible = false;    //hello user

                LinkButton6.Visible = true;    //admin login
                LinkButton7.Visible = false;    //adminauthormanagement
                LinkButton8.Visible = false;    //adminpublishermanagement
                LinkButton9.Visible = false;     //adminbookinventory
                LinkButton10.Visible = false;    //adminbookissuing
                LinkButton11.Visible = false;    //adminmembermanagement
            }
            else if (Session["role"].Equals("user"))
            {
                LinkButton2.Visible = false;   //user login btn
                LinkButton3.Visible = false;   //Sign up
                LinkButton4.Visible = true;    //logout
                LinkButton5.Visible = true;    //hello user
                LinkButton5.Text = "Hello" + Session["username"].ToString();

                LinkButton6.Visible = true;    //admin login
                LinkButton7.Visible = false;    //adminauthormanagement
                LinkButton8.Visible = false;    //adminpublishermanagement
                LinkButton9.Visible = false;     //adminbookinventory
                LinkButton10.Visible = false;    //adminbookissuing
                LinkButton11.Visible = false;    //adminmembermanagement
            }
            else if (Session["role"].Equals("admin"))
            {
                LinkButton2.Visible = false;   //user login btn
                LinkButton3.Visible = false;   //Sign up
                LinkButton4.Visible = true;    //logout
                LinkButton5.Visible = true;    //hello user
                LinkButton5.Text = "Hello Admin";

                LinkButton6.Visible = false;    //admin login
                LinkButton7.Visible = true;    //adminauthormanagement
                LinkButton8.Visible = true;    //adminpublishermanagement
                LinkButton9.Visible = true;     //adminbookinventory
                LinkButton10.Visible = true;    //adminbookissuing
                LinkButton11.Visible = true;    //adminmembermanagement
            }
        }


    
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx"); 
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
             Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton2.Visible = true;   //user login btn
            LinkButton3.Visible = true;   //Sign up
            LinkButton4.Visible = false;    //logout
            LinkButton5.Visible = false;    //hello user

            LinkButton6.Visible = true;    //admin login
            LinkButton7.Visible = false;    //adminauthormanagement
            LinkButton8.Visible = false;    //adminpublishermanagement
            LinkButton9.Visible = false;     //adminbookinventory
            LinkButton10.Visible = false;    //adminbookissuing
            LinkButton11.Visible = false;    //adminmembermanagement
        }

       // view profile
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}