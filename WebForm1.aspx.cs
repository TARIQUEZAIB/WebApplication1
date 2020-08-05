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
                TextBox1.Text = "0";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ClicksCount = ClicksCount + 1;
            //TextBox1.Text = ClicksCount.ToString();

            //if (ViewState["Clicks"] != null)
            //{
            //    ClicksCount = (int)ViewState["Clicks"] + 1;
            //}
            //TextBox1.Text = ClicksCount.ToString(); ;
            //ViewState["Clicks"] = ClicksCount;

            int ClicksCount = Convert.ToInt32(TextBox1.Text) + 1;
            TextBox1.Text = ClicksCount.ToString();
        }
    }
}