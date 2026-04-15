using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ThuHang
{
    internal class KETNOI_CSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;
        public void KetNoi_Dulieu()
        {
            string str = @"Data Source=ADMIN\MSSQLSERVERR;Initial Catalog=SQL2_NHOM06_QLy_BVMB;Integrated Security=True";
            cnn = new SqlConnection(str);
            cnn.Open();
        }
        public void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataTable LayBang(string sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public void ThucThi(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}