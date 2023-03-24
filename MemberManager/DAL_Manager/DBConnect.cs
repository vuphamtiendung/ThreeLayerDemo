using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Manager
{
    public class DBConnect
    {
        public SqlConnection _conn = new SqlConnection("Server=Admin; Database=MemberManager; integrated security = true");
    }
}
