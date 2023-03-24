using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Manager;
using DTO_Manager;

namespace BUS_Manager
{
    public class BUS_Member
    {
        DAL_Member dalMember = new DAL_Member();
        public DataTable getDataTable()
        {
            return dalMember.GetMember();
        }

        public bool AddMemer(DTO_Member member)
        {
            return dalMember.AddMember(member);
        }

        public bool UpdateMember(DTO_Member member)
        {
            return dalMember.UpdateMember(member);  
        }

        public bool DeleteMember(int memberId)
        {
            return dalMember.DeleteMember(memberId);
        }
    }
}
