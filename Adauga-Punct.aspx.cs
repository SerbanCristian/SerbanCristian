using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebS5
{
    public partial class Adauga_Punct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet sursa = new DataSet();
            sursa.ReadXmlSchema(Server.MapPath("~/App_Data/SchemaAPunct.xsd"));
            sursa.ReadXml(Server.MapPath("~/App_Data/dbApunct.XML"));
            DataRow dr = sursa.Tables["Punct"].NewRow();
            dr["Denumire"] = txtDenumire.Text;
            dr["CoordonataX"] = txtX.Text;
            dr["CoordonataY"] = txtY.Text;
            dr["EsteVizibil"] = chkEsteVizibil.Checked?1:0;
            dr["DataCreare"] = DateTime.Now;
            sursa.Tables["Punct"].Rows.Add(dr);
            sursa.WriteXml(Server.MapPath("~/App_Data/dbApunct.XML"));
            Response.Redirect("~/lista-puncte", true);
        }
    }
}