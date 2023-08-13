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
    public partial class ej3b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=PCOK\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True");
            string valor = Request.QueryString["valor"];
            if (!IsPostBack)
            {
                cn.Open();
                SqlDataAdapter dr = new SqlDataAdapter("select * from Libros where IdTema =" + (valor), cn);
                DataSet ds = new DataSet();
                dr.Fill(ds, "Tema");
                GridView1.DataSource = ds.Tables["Tema"];
                GridView1.DataBind();
                cn.Close();
            }
  
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("ej3a.aspx");

        }
    }
}