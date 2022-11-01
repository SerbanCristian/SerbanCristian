using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebS5
{
    public partial class Generare_Schema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Punct";
            DataColumn col = new DataColumn();
            col.ColumnName = "PunctID";
            col.DataType = typeof(Guid);
            //col.DataType = typeof(Int16);
            col.AllowDBNull = false;
            //col.AutoIncrement = true;
            //col.AutoIncrementSeed = 0;
            //col.AutoIncrementStep = 1;
            dt.Columns.Add(col);
            col = new DataColumn();
            col.ColumnName = "Denumire";
            col.DataType = typeof(String);
            col.MaxLength = 25;
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            col = new DataColumn();
            col.ColumnName = "CoordonataX";
            col.DataType = typeof(Decimal);
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            col = new DataColumn();
            col.ColumnName = "CoordonataY";
            col.DataType = typeof(Decimal);
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            col = new DataColumn();
            col.ColumnName = "EsteVizibil";
            col.DataType = typeof(Boolean);
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            col = new DataColumn();
            col.ColumnName = "DataCreare";
            col.DataType = typeof(DateTime);
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            ds.Tables.Add(dt);

            ds.WriteXmlSchema(Server.MapPath("~/App_Data/SchemaTPunct.xsd"));

            //ds =new DataSet();
            //ds.ReadXml(Server.MapPath("~/dbApunct.xml"));
            //ds.WriteXmlSchema(Server.MapPath("~/App_Data/SchemaDefaultPunct.xsd"));
        }
    }
}