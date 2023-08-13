using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Tp7
{
    public partial class Ej1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tabla"] == null)
            {
                Session["tabla"] = crearTabla();
            }
        }

       protected void LvSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["tabla"] == null)
            {
                Session["tabla"] = crearTabla();
            }
            ///agregarFila((DataTable)Session["tabla"], , , );
        }

        public DataTable crearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn col = new DataColumn("ID_SUCURSAL", System.Type.GetType("System.String"));
            dt.Columns.Add(col);
            col = new DataColumn("NOMBRE", System.Type.GetType("System.String"));
            dt.Columns.Add(col);
            col = new DataColumn("DESCRIPCION", System.Type.GetType("System.String"));
            dt.Columns.Add(col);
            return dt;
        }

        public void agregarFila(DataTable tabla, String idsuc, String nombre, String desc)
        {
            bool exists = tabla.Select().ToList().Exists(row => row["ID_SUCURSAL"].ToString() == idsuc);
            if (exists)
            {
                ///LabelMostar.Text = "Esta sucursal ya fue seleccionada";
                return;
            }
            DataRow dr = tabla.NewRow();
            dr["ID_SUCURSAL"] = idsuc;
            dr["NOMBRE"] = nombre;
            dr["DESCRIPCION"] = desc;
            tabla.Rows.Add(dr);
        }

        protected void BtnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "comandoSeleccionar")
            {
                string nombreSuc, descSuc;
                foreach (ListViewItem lvItem in LvSucursales.Items)
                {
                    string idSucActual = ((Label)lvItem.FindControl("lblId")).Text;
                    if (e.CommandArgument.ToString() == idSucActual)
                    {
                        nombreSuc = ((Label)lvItem.FindControl("NombreSucursalLabel")).Text;
                        descSuc = ((Label)lvItem.FindControl("DescripcionSucursalLabel")).Text;

                        agregarFila((DataTable)Session["tabla"], idSucActual, nombreSuc, descSuc);
                        return;
                    }
                }
            }
        }

        protected void Provicias_Command1(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sp")
            {
                string consulta = "SELECT * FROM [Sucursal] where [Id_ProvinciaSucursal] = '" + e.CommandArgument.ToString() + "' ";
                SqlDataSource4.SelectCommand = consulta;
                SqlDataSource4.DataBind();
                LvSucursales.DataBind();
            }
        }

        protected void BT_Busqueda_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text!=" ")
            {
                string consul = "SELECT * FROM [Sucursal] where [NombreSucursal] ='" + TextBox1.Text + "' ";
                SqlDataSource4.SelectCommand = consul;
                SqlDataSource4.DataBind();
                LvSucursales.DataBind();

            }
        }
    }
}/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP7_GRUPO3.Clases;
using System.Data;

namespace TP7_GRUPO3
{
    public partial class SeleccionarSucursales2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tabla"] == null)
            {
                Session["tabla"] = crearTabla();
            }
        }

        protected void lvSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["tabla"] == null)
            {
                Session["tabla"] = crearTabla();
            }
            ///agregarFila((DataTable)Session["tabla"], , , );
        }

        public DataTable crearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn col = new DataColumn("ID_SUCURSAL", System.Type.GetType("System.String"));
            dt.Columns.Add(col);
            col = new DataColumn("NOMBRE", System.Type.GetType("System.String"));
            dt.Columns.Add(col);
            col = new DataColumn("DESCRIPCION", System.Type.GetType("System.String"));
            dt.Columns.Add(col);
            return dt;
        }

        public void agregarFila(DataTable tabla, String idsuc, String nombre, String desc)
        {
            bool exists = tabla.Select().ToList().Exists(row => row["ID_SUCURSAL"].ToString() == idsuc);
            if (exists)
            {
                ///LabelMostar.Text = "Esta sucursal ya fue seleccionada";
                return;
            }
            DataRow dr = tabla.NewRow();
            dr["ID_SUCURSAL"] = idsuc;
            dr["NOMBRE"] = nombre;
            dr["DESCRIPCION"] = desc;
            tabla.Rows.Add(dr);
        }

        protected void BtnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "comandoSeleccionar")
            {
                string nombreSuc, descSuc;
                foreach (ListViewItem lvItem in lvSucursales.Items)
                {
                    string idSucActual = ((Label)lvItem.FindControl("lblId")).Text;
                    if (e.CommandArgument.ToString() == idSucActual)
                    {
                        nombreSuc = ((Label)lvItem.FindControl("NombreSucursalLabel")).Text;
                        descSuc = ((Label)lvItem.FindControl("DescripcionSucursalLabel")).Text;

                        agregarFila((DataTable)Session["tabla"], idSucActual, nombreSuc, descSuc);
                        return;
                    }
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlDataSource2.SelectCommand = "SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal], [Id_Sucursal] FROM[Sucursal] WHERE LOWER(NombreSucursal) LIKE LOWER('%" + txtBuscar.Text.ToString() + "%')";
            txtBuscar.Text = "";
        }

        protected void Btnsucursal_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "btnCommand")
            {
                SqlDataSource2.SelectCommand = "SELECT [Id_Sucursal] ,[NombreSucursal] ,[DescripcionSucursal] ,[Id_HorarioSucursal] ,[Id_ProvinciaSucursal] ,[DireccionSucursal] ,[URL_Imagen_Sucursal] FROM [BDSucursales].[dbo].[Sucursal] INNER JOIN dbo.Provincia ON[Sucursal].Id_ProvinciaSucursal = Provincia.Id_Provincia WHERE LOWER(DescripcionProvincia) LIKE LOWER('%" + e.CommandArgument.ToString() + "%')";
            }
        }
    }

}*/