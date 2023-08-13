using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        ///CustomValidator que se utiliza para no repetir en el DropDownList las localidades 
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            foreach (ListItem Localidad in DropDownList1.Items)
            {///Evalua y guarda el resultado de la comparacion 
                args.IsValid = (textLocalidad.Text.ToUpper() != Localidad.Text.ToUpper()); 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {///para con el resultado del CustomValidator que utilizamos antes no pueda repetir la localidad en 
         ///el DropDownList
            if (CustomValidator1.IsValid == true) 
            {
                Label1.Text = "Localida fue registrada";
                DropDownList1.Items.Add(textLocalidad.Text);
            }
            else{ Label1.Text = ""; }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Inicio.aspx");
        }
    }
}