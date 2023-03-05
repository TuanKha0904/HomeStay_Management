using Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Homestay_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void txt_TenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)35 || (e.KeyChar > (char)47 && e.KeyChar < (char)58) || (e.KeyChar > (char)64 && e.KeyChar < (char)91) || (e.KeyChar > (char)96 && e.KeyChar < (char)123) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ckbox_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox_HienThiMatKhau.Checked)
            {
                txt_MatKhau.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text == "" || txt_MatKhau.Text == "")
                MessageBox.Show("Các trường không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connect;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DANGNHAP";
            cmd.Parameters.AddWithValue ("@TenDangNhap", txt_TenDangNhap.Text);
            cmd.Parameters.AddWithValue("@MatKhau", txt_MatKhau.Text);
            cmd.Connection = conn;
            object kq = cmd.ExecuteScalar();
            int code = (int)kq;
            if (code == 1)
            {
                this.Hide();
                Form AdminForm = new frm_AdminForm(txt_TenDangNhap.Text, txt_MatKhau.Text);
                AdminForm.Show();
            }    
            else if (code == 2)
            {
                this.Hide();
                Form ReceptionForm = new frm_ReceptionForm(txt_TenDangNhap.Text, txt_MatKhau.Text);
                ReceptionForm.Show();
            } 
            else if (code == 3)
            {
                this.Hide();
                Form UserForm = new frm_UserForm(txt_TenDangNhap.Text, txt_MatKhau.Text);
                UserForm.Show();
            }
            else if (code == 4)
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Không có tài khoản này, vui lòng đăng kí tài khoản mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();            
        }

        private void linklb_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form DangKi = new frm_REGISTER();
            this.Hide();
            DangKi.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (dlr == DialogResult.OK)
                Application.Exit();
        }

        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)35 || (e.KeyChar > (char)47 && e.KeyChar < (char)58) || (e.KeyChar > (char)64 && e.KeyChar < (char)91) || (e.KeyChar > (char)96 && e.KeyChar < (char)123) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        
    }
}
