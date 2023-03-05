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
    public partial class frm_HoSo : Form
    {
        string TenDN, MK;
        string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
        public frm_HoSo()
        {
            InitializeComponent();
        }

        private void tAI_KHOAN_APPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAI_KHOAN_APPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOMESTAY_MANAGEMENTDataSet);

        }

        private void frm_HoSo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOMESTAY_MANAGEMENTDataSet.TAI_KHOAN_APP' table. You can move, or remove it, as needed.
            this.tAI_KHOAN_APPTableAdapter.Fill(this.hOMESTAY_MANAGEMENTDataSet.TAI_KHOAN_APP);
            this.txt_TenTK.Text = TenDN;
            this.txt_MatKhau.Text = MK;
            SqlConnection conn = new SqlConnection(connect);
            string query = string.Format("SELECT Ho_Ten, Ngay_Sinh, Gioi_Tinh FROM TAI_KHOAN_APP WHERE Ten_TK = '{0}' AND Mat_Khau = '{1}'", TenDN, MK);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string hoten = reader.GetString(0);
                    DateTime ngaysinh = (DateTime)reader["Ngay_Sinh"];
                    string []date = ngaysinh.GetDateTimeFormats();
                    string ngaysinhdate = date[1];
                    string gioitinh = reader["Gioi_Tinh"].ToString();
                    txt_HoTen.Text = hoten;
                    txt_NgaySinh.Text = ngaysinhdate;
                    txt_GioiTinh.Text = gioitinh;
                }
            }
            conn.Close();
            dtp_NgaySinh.Visible = false;
            cbb_GioiTinh.Visible = false;
            txt_MKMoi.Visible = false;
            lb_mkmoi.Visible = false;
            btn_LuuMK.Visible = false;
            lb_mkmoi.Visible = false;
             txt_NhapLaiMK.Visible = false;
        }

        private void btn_Chinhsua_Click(object sender, EventArgs e)
        {
            dtp_NgaySinh.Visible = true;
            cbb_GioiTinh.Visible  = true;
            txt_HoTen.Enabled = true;
            txt_HoTen.BackColor = Color.White;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE TAI_KHOAN_APP SET Ho_Ten = N'{0}', Ngay_Sinh = '{1}', Gioi_Tinh = N'{2}' WHERE Ten_TK = '{3}' AND Mat_Khau = '{4}' ", txt_HoTen.Text, dtp_NgaySinh.Text, cbb_GioiTinh.Text, TenDN, MK);
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            DateTime ngaysinh = (DateTime)dtp_NgaySinh.Value;
            string[] date = ngaysinh.GetDateTimeFormats();
            string ngaysinhdate = date[1];
            txt_NgaySinh.Text = ngaysinhdate;
            txt_GioiTinh.Text = cbb_GioiTinh.Text;
            dtp_NgaySinh.Visible = false;
            cbb_GioiTinh.Visible = false;
            txt_HoTen.Enabled = false;
            txt_HoTen.BackColor = SystemColors.InactiveCaption;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = false;
            txt_MKMoi.UseSystemPasswordChar = false;
            txt_NhapLaiMK.UseSystemPasswordChar = false;
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txt_TenTK.Visible = false;
            txt_HoTen.Visible = false;
            txt_NgaySinh.Visible=false;
            txt_GioiTinh.Visible = false;
            lb_mkmoi.Visible = true;
            lb_NhapLaiMK.Visible = true;
            txt_MKMoi.Visible = true;
            txt_NhapLaiMK.Visible = true;
            txt_MKMoi.Enabled = true;
            txt_NhapLaiMK.Enabled = true;
            txt_MKMoi.BackColor = Color.White;
            txt_NhapLaiMK.BackColor = Color.White;
            btn_LuuMK.Visible = true;
        }

        private void btn_LuuMK_Click(object sender, EventArgs e)
        {
            if (txt_MKMoi.Text == "" || txt_NhapLaiMK.Text == "")
            {
                MessageBox.Show("Các trường nhập không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_MatKhau.Text == txt_MKMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác với mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_MKMoi.Text != txt_NhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = string.Format("UPDATE TAI_KHOAN_APP SET Mat_Khau = '{0}' WHERE Ten_TK = '{1}'", txt_MKMoi.Text, txt_TenTK.Text);
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                txt_MatKhau.Text = txt_MKMoi.Text;
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txt_TenTK.Visible = true;
                txt_HoTen.Visible = true;
                txt_NgaySinh.Visible = true;
                txt_GioiTinh.Visible = true;
                lb_mkmoi.Visible = false;
                lb_NhapLaiMK.Visible = false;
                txt_MKMoi.Visible = false;
                txt_NhapLaiMK.Visible = false;
                txt_MKMoi.Enabled = false;
                txt_NhapLaiMK.Enabled = false;
                txt_MKMoi.BackColor = SystemColors.InactiveCaption;
                txt_NhapLaiMK.BackColor = SystemColors.InactiveCaption;
                btn_LuuMK.Visible = false;
            }
        }

        public frm_HoSo(string tenDN, string mK) :this()
        {
            TenDN = tenDN;
            MK = mK;
        }

       
    }
}
