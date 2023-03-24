using DTO_Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_Manager
{
    public class DAL_Member : DBConnect
    {
        public DataTable GetMember()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From THANHVIEN", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool AddMember(DTO_Member member)
        {
            try
            {
                _conn.Open();
                string query = string.Format($"Insert Into THANHVIEN (TV_NAME, TV_PHONE, TV_EMAIL) Values (N'{member.MemberName}', N'{member.MemberPhone}', N'{member.MemberEmail}')");
                SqlCommand cmd = new SqlCommand(query, _conn);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool UpdateMember(DTO_Member member)
        {
            try
            {
                _conn.Open();
                string query = string.Format($"Update THANHVIEN Set TV_Name = '{member.MemberName}', TV_PHONE = '{member.MemberPhone}', TV_EMAIL = '{member.MemberEmail}' Where TV_ID '{member.MemberId}'");
                SqlCommand cmd = new SqlCommand(query, _conn); 
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DeleteMember(int memberId)
        {
            try
            {
                _conn.Open();
                string query = string.Format($"Delete From THANHVIEN Where TV_ID = '{memberId}'");
                SqlCommand cmd = new SqlCommand(query, _conn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
