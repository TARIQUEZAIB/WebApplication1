using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                LoadCity();
                TextBox1.Text = "0";
            }
        }

        private void LoadCity() {
            
            ddlCity.Items.Add(new ListItem("USA", "USA"));
            ddlCity.Items.Add(new ListItem("India", "India"));
            ddlCity.Items.Add(new ListItem("Nepal", "Nepal"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ClicksCount = ClicksCount + 1;
            //TextBox1.Text = ClicksCount.ToString();

            if (Session["Clicks"] != null)
            {
                ClicksCount = (int)Session["Clicks"] + 1;
            }
            TextBox1.Text = ClicksCount.ToString(); ;
            Session["Clicks"] = ClicksCount;

            //int ClicksCount = Convert.ToInt32(TextBox1.Text) + 1;
            //TextBox1.Text = ClicksCount.ToString();
            Response.Redirect("WebForm2.aspx");
        }
    }
}