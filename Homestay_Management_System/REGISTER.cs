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
    public partial class frm_REGISTER : Form
    {
        public frm_REGISTER()
        {
            InitializeComponent();
        }

        private void ckb_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HienThiMatKhau.Checked)
            {
                txt_MatKhau.PasswordChar = (char)0;
                txt_NhapLaiMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
                txt_NhapLaiMatKhau.PasswordChar = '*';

            }
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

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            if (txt_HoTen.Text == "" || txt_MatKhau.Text == "" || txt_NhapLaiMatKhau.Text == "" || txt_TenDangNhap.Text == "" || dtpicker_NgaySinh.Value == null || (radioBtn_Nam.Checked == false && radioBtn_Nu.Checked == false))
            {
                MessageBox.Show("Các trường không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_MatKhau.Text != txt_NhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string gioitinh;
                if (radioBtn_Nam.Checked)
                    gioitinh = radioBtn_Nam.Text;
                else
                    gioitinh = radioBtn_Nu.Text;

                string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
                string insert = string.Format("INSERT INTO TAI_KHOAN_APP(Ten_TK, Mat_Khau, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ngay_Tao) VALUES ('{0}', '{1}', N'{2}', '{3}', N'{4}', GETDATE())", txt_TenDangNhap.Text, txt_MatKhau.Text, txt_HoTen.Text, dtpicker_NgaySinh.Value, gioitinh);
                string kt = string.Format("SELECT COUNT(*) FROM TAI_KHOAN_APP WHERE Ten_TK = '{0}'", txt_TenDangNhap.Text);
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connect;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = kt;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                int count;
                count = (int)cmd.ExecuteScalar();
                conn.Close();
                if (count == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = insert;
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void linklb_DangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form DangNhap = new frm_Login();
            DangNhap.Show();
            this.Close();
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

        private void txt_NhapLaiMatKhau_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (dlr == DialogResult.OK)
                Application.Exit();
        }

       
    }
}
