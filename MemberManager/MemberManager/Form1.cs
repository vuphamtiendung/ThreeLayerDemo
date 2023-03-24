using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Manager;
using BUS_Manager;

namespace MemberManager
{
    public partial class btnAdd : Form
    {
        BUS_Member busMember = new BUS_Member();
        public btnAdd()
        {
            InitializeComponent();
        }

        private void grbMember_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            int numberPhone = Convert.ToInt32(txtNumberPhone.Text);
            string email = txtEmail.Text;
            if(fullName != " " &&  numberPhone != 0 && email != " ")
            {
                DTO_Member member = new DTO_Member(0, fullName, numberPhone, email);
                if (busMember.AddMemer(member))
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!");
                    dgvMember.DataSource = busMember.getDataTable();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin");
            }
            
        }
    }
}
