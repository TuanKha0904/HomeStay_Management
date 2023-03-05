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
    public partial class frm_DatPhong : Form
    {
        public frm_DatPhong()
        {
            InitializeComponent();
        }

        private void kHACH_HANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACH_HANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOMESTAY_MANAGEMENTDataSet);

        }

        private void frm_DatPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOMESTAY_MANAGEMENTDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.hOMESTAY_MANAGEMENTDataSet.PHONG);
            // TODO: This line of code loads data into the 'hOMESTAY_MANAGEMENTDataSet.THUE' table. You can move, or remove it, as needed.
            this.tHUETableAdapter.Fill(this.hOMESTAY_MANAGEMENTDataSet.THUE);
            // TODO: This line of code loads data into the 'hOMESTAY_MANAGEMENTDataSet.KHACH_HANG' table. You can move, or remove it, as needed.
            this.kHACH_HANGTableAdapter.Fill(this.hOMESTAY_MANAGEMENTDataSet.KHACH_HANG);
            Load_Combobox();
        }

        private void txt_SoCMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
            if (txt_HoTen.Text == "" || dtp_NgaySinh.Value == null || cbb_GioiTinh.Text == "" || txt_QuocTich.Text == "" || txt_SoCMT.Text == "" || txt_SDT.Text == "")
            {
                MessageBox.Show("Các trường THÔNG TIN không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "KT_KHACHHANG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CMT", txt_SoCMT.Text);
                cmd.Connection = conn;
                int kq = (int)cmd.ExecuteScalar();
                conn.Close();
                if (kq == 1)
                {
                    MessageBox.Show("Đã có khách hàng này, bạn có thể sử dụng để đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query = string.Format("INSERT INTO KHACH_HANG(Ho_Ten, Ngay_Sinh, Gioi_Tinh, Quoc_Tich, So_CMT, So_ĐT) VALUES(N'{0}', '{1}', N'{2}', N'{3}', '{4}', '{5}')", txt_HoTen.Text, dtp_NgaySinh.Text, cbb_GioiTinh.Text, txt_QuocTich.Text, txt_SoCMT.Text, txt_SDT.Text);
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = query;
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Connection = conn;
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }    
        }

        private void btn_Thue_Click(object sender, EventArgs e)
        {
            string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
            if (ma_PhongComboBox.Text == "" || dtp_NgayThue.Text == "" || dtp_NgayTra.Text == "")
            {
                MessageBox.Show("Các trường THUÊ không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtp_NgayTra.Value < dtp_NgayThue.Value)
            {
                MessageBox.Show("Ngày trả không được nhỏ hơn ngày thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(connect);
                string queryma_kh = string.Format("SELECT Ma_KH FROM KHACH_HANG WHERE So_CMT = '{0}'",txt_SoCMT.Text);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryma_kh, conn);
                string ma_kh = cmd.ExecuteScalar().ToString();
                conn.Close();
                
                string query_tienphong = string.Format("SELECT Gia_Phong FROM PHONG WHERE Ma_Phong = '{0}'", ma_PhongComboBox.Text);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(query_tienphong, conn);
                int songay = (int)dtp_NgayTra.Value.DayOfYear - dtp_NgayThue.Value.DayOfYear;
                string sotien = cmd1.ExecuteScalar().ToString();
                float thanhtien = songay * float.Parse(sotien);
                conn.Close();

                string query_insert = string.Format("INSERT INTO THUE VALUES ('{0}', '{1}', '{2}', '{3}', {4}, ' ' )", ma_kh, ma_PhongComboBox.Text, dtp_NgayThue.Text, dtp_NgayTra.Text, thanhtien);
                conn.Open();
                SqlCommand cmd2 = new SqlCommand(query_insert, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                conn.Close();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
            int index = tHUEDataGridView.CurrentCell.RowIndex;
            string Ma_KH = tHUEDataGridView.Rows[index].Cells[0].Value.ToString();
            string ma_P = tHUEDataGridView.Rows[index].Cells[1].Value.ToString();
            string query = string.Format("DELETE THUE WHERE Ma_KH = '{0}' AND Ma_Phong = '{1}'", Ma_KH, ma_P);
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            tHUEDataGridView.Rows.RemoveAt(index);
        }

        public void Load_Combobox()
        {
            DataTable dt = new DataTable();
            string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Ma_Phong FROM PHONG", conn);
            da.Fill(dt);
            conn.Close();
            ma_PhongComboBox.DataSource = dt;
            ma_PhongComboBox.DisplayMember = "Ma_Phong";
            ma_PhongComboBox.ValueMember = "Ma_Phong";
        }
    }
}
