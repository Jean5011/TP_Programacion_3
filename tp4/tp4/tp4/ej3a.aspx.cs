using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace tp4
{
    public partial class ej3a : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            if (!IsPostBack)
            {
                SqlConnection cn = new SqlConnection("Data Source=PCOK\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True");
                cn.Open();
                SqlDataAdapter dr = new SqlDataAdapter("select * from Temas", cn);
                DataSet ds = new DataSet();
                dr.Fill(ds, "Tema");
                DropDownList1.DataSource = ds.Tables["Tema"];
                DropDownList1.DataTextField = "Tema";
                DropDownList1.DataValueField = "IdTema";
                DropDownList1.DataBind();
                cn.Close();
            }
           
       }
        

        protected void Libro_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex >-1)
            {
                Label1.Visible = false;
                Response.Redirect("ej3b.aspx?valor=" + DropDownList1.SelectedValue);
            }
            else
            {
                Label1.Visible = true;
            }
            
           
        }
    }
}