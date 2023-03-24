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
            this.CenterToScreen();
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

        private void dgv_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvMember.SelectedRows[0];
                txtFullName.Text = row.Cells[1].Value.ToString();
                txtNumberPhone.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lõi xảy ra, chi tiết: " + ex.Message);
            }
        }

      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvMember.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[1].Value.ToString());

                if (busMember.DeleteMember(id))
                {
                    MessageBox.Show("Xoá thành công");
                    dgvMember.DataSource = busMember.getDataTable();
                }
                else
                {
                    MessageBox.Show("Xoá thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra! chi tiết: " + ex.Message);
            }
        }

        private void btnAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
