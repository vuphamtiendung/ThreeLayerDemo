using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manager
{
    public class DTO_Member
    {
        private int _memberId;
        private string _memberName;
        private int _memberPhone;
        private string _memberEmail;

        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public string MemberName { get { return _memberName; } set { _memberName = value; } }
        public int MemberPhone { get { return _memberPhone;} set { _memberPhone = value; } }
        public string MemberEmail { get { return _memberName; } set { _memberEmail = value; } }


        public DTO_Member() { }
        public DTO_Member(int memberId, string memberName, int memberPhone, string memberEmail) 
        {
            _memberId = memberId;
            _memberName = memberName;
            _memberPhone = memberPhone;
            _memberEmail = memberEmail;
        }
    }
}
