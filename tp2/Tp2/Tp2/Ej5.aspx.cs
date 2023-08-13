using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp2
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// Para sacar el valor y evalual de los DropDownList
       float Cant_Memoria()
        {
            float Memoria = 0;
            if (float.TryParse(DropDownList.SelectedValue, out Memoria))
            {
                return Memoria;
            }
            return Memoria;
        }

        /// paraa CheckBoxList1
        float obtenerAccesoriosPrecio()
        {
            float accesorios = 0;
            foreach (ListItem items in CheckBoxList1.Items) {
                if (items.Selected)
                {
                    float accesorioParsed;
                    if (float.TryParse(items.Value, out accesorioParsed))
                    {
                        accesorios += accesorioParsed;
                    }
                }
            }
            return accesorios;
        }

        protected void Button_Click(object sender, EventArgs e)
        {

            float Num = Cant_Memoria() + obtenerAccesoriosPrecio();
            Label.Text = Num.ToString();

        }
    }
}