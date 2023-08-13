using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LKrojo_Click(object sender, EventArgs e)
        {
            Label.ForeColor = System.Drawing.Color.Red;
        }

        protected void Lkazul_Click(object sender, EventArgs e)
        {
            Label.ForeColor = System.Drawing.Color.Blue;
        }

        protected void LKverde_Click(object sender, EventArgs e)
        {
            Label.ForeColor = System.Drawing.Color.Green;
        }
    }
}