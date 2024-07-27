using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ontap_cuoiki
{
    public partial class SanPham : System.Web.UI.Page
    {
        //string sql_connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\NND\Top500TG\HK1-Nam3\KT_Thuongmaidientu\C_Sharp\ontap_cuoiki\ontap_cuoiki\App_Data\Ontap.mdf;Integrated Security=True";
        Handle hdl = new Handle();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["dm"] == null)
            {
                q = "SELECT * FROM HOA";
            }
            else
            {
                string danhmuc = Context.Items["dm"].ToString();
                q = "SELECT * FROM HOA WHERE MaDM = '" + danhmuc + "'";
            }
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter(q, sql_connect);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //this.DataList1.DataSource = dt;
                this.DataList1.DataSource = hdl.GetDataSQL(q);
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mahoa = ((Button)sender).CommandArgument;
            Context.Items["hoa"] = mahoa;
            Server.Transfer("Detail.aspx");
        }
    }
}