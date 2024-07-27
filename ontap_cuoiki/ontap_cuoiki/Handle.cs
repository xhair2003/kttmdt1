using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ontap_cuoiki
{
    public class Handle
    {
        SqlConnection connect;
        // phuong thuc ket noi data
        private void ConnectData()
        {
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\NND\Top500TG\HK1-Nam3\KT_Thuongmaidientu\C_Sharp\ontap_cuoiki\ontap_cuoiki\App_Data\Ontap.mdf;Integrated Security=True");
            connect.Open(); // mở kết nối
        }

        // phương thức đóng kết nối
        private void DisconnectData()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
        // phương thức lấy dữ liệu
        // tạo hàm lấy dữ liệu có kiểu dữ liệu là DataTable
        // giá trị truyền vào là 1 chuỗi SQL
        public DataTable GetDataSQL(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                ConnectData();
                SqlDataAdapter adap = new SqlDataAdapter(sql, connect);
                adap.Fill(dt);
            } catch
            {
                dt = null;
            } finally
            {
                DisconnectData();
            }
            return dt; // kết quả tả về là 1 DataTable
        }
    }
}