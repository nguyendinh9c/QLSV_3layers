using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLSV_3layers
{
    public class Database
    {
        private string connetionString = "Data Source=DESKTOP-6KVLN11;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True;";
        private Microsoft.Data.SqlClient.SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                conn = new SqlConnection(connetionString);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("kết nối thất bại : " + ex.Message);
            }
        }
        public DataTable SelectData(string sql, List<CustomParameter> IstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para in IstPara)
                {
                    cmd.Parameters.AddWithValue(para.key,para.value);
                }    
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: "+ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select (string sql)
        {
            try 
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }finally
            {
                conn.Close();
            }
        }

        public int ExeCute(string sql,List<CustomParameter> IstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in IstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }finally
            {
                conn.Close();
            }
        }
    }
}
