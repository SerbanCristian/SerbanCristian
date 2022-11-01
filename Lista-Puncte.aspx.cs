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
    public partial class Lista_Puncte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet sursa = new DataSet();
            //sursa.ReadXmlSchema(Server.MapPath("~/App_Data/SchemaAPunct.xsd"));
            //sursa.ReadXml(Server.MapPath("~/App_Data/dbApunct.XML"));
            sursa.ReadXmlSchema(Server.MapPath("~/App_Data/SchemaTPunct.xsd"));
            sursa.ReadXml(Server.MapPath("~/App_Data/dbTpunct.XML"));
            GVPuncte.DataSource = sursa.Tables[0];
            GVPuncte.DataBind();
        }
    }
}