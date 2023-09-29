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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homestay_Management_System
{
    public partial class frm_XemPhong : Form
    {
        private DataTable datatable;
        public frm_XemPhong()
        {
            InitializeComponent();
        }

        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOMESTAY_MANAGEMENTDataSet);

        }

        private void frm_XemPhong_Load(object sender, EventArgs e)
        {
            this.ma_PhongTextBox.Enabled = false;
            this.ten_PhongTextBox.Enabled = false;
            this.loai_PhongTextBox.Enabled = false;
            this.gia_PhongTextBox.Enabled = false;
            // TODO: This line of code loads data into the 'hOMESTAY_MANAGEMENTDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.hOMESTAY_MANAGEMENTDataSet.PHONG);
        }
        
        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (pHONGDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = pHONGDataGridView.SelectedRows[0];
                    int selectedRowIndex = pHONGDataGridView.SelectedRows[0].Index;

                    // Lấy thông tin từ dòng được chọn
                    string Ma_Phong = selectedRow.Cells[0].Value.ToString();
                    string Ten_Phong = selectedRow.Cells[1].Value.ToString();
                    string Loai_Phong = selectedRow.Cells[2].Value.ToString();
                    string Gia_Phong = selectedRow.Cells[3].Value.ToString();

                    // Hiển thị thông tin trong các hộp văn bản
                    ma_PhongTextBox.Text = Ma_Phong;
                    ten_PhongTextBox.Text = Ten_Phong;
                    loai_PhongTextBox.Text = Loai_Phong;
                    gia_PhongTextBox.Text = Gia_Phong;

                    // Kích hoạt sửa thông tin
                    this.ten_PhongTextBox.Enabled = true;
                    this.loai_PhongTextBox.Enabled = true;
                    this.gia_PhongTextBox.Enabled = true;
                    this.loai_PhongTextBox.BackColor = Color.White;
                    this.ten_PhongTextBox.BackColor = Color.White;
                    this.gia_PhongTextBox.BackColor = Color.White;
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    MessageBox.Show("Lỗi khi tải thông tin phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa!!!");
            }
        }
        private void LoadDataIntoDataGridView()
        {
            string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
            string query = "SELECT * FROM PHONG"; // Đảm bảo truy vấn của bạn trả về tất cả dữ liệu bạn muốn hiển thị trong DataGridView.

            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                pHONGDataGridView.DataSource = dataTable;

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
            int index = pHONGDataGridView.CurrentCell.RowIndex;
            string Ma_Phong = pHONGDataGridView.Rows[index].Cells[0].Value.ToString();
            string query = string.Format("UPDATE PHONG SET Loai_Phong = N'{0}', Ten_Phong = '{1}', Gia_Phong = '{2}' WHERE Ma_Phong = '{3}'", loai_PhongTextBox.Text, ten_PhongTextBox.Text, gia_PhongTextBox.Text, Ma_Phong);
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadDataIntoDataGridView();
            this.ten_PhongTextBox.Enabled = false;
            this.loai_PhongTextBox.Enabled = false;
            this.gia_PhongTextBox.Enabled = false;
            this.ma_PhongTextBox.Enabled = false;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
            int index = pHONGDataGridView.CurrentCell.RowIndex;
            string Ma_Phong = pHONGDataGridView.Rows[index].Cells[0].Value.ToString();
            string query = string.Format("DELETE PHONG WHERE Ma_Phong = '{0}'", Ma_Phong);
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            pHONGDataGridView.Rows.RemoveAt(index);
        }

        private void ma_PhongTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gia_PhongTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            this.loai_PhongTextBox.BackColor = Color.White;
            this.ten_PhongTextBox.BackColor = Color.White;
            this.gia_PhongTextBox.BackColor = Color.White;
            this.ma_PhongTextBox.BackColor = Color.White;
            this.ten_PhongTextBox.Enabled = true;
            this.loai_PhongTextBox.Enabled = true;
            this.gia_PhongTextBox.Enabled = true;
            this.ma_PhongTextBox.Enabled = true;
        }

        private void btn_SaveImage_Click(object sender, EventArgs e)
        {
            if (ma_PhongTextBox.Text == "" || ten_PhongTextBox.Text == "" || loai_PhongTextBox.Text == "" || gia_PhongTextBox.Text == "")
            {
                MessageBox.Show("Các trường không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "THEMPHONG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhong", ma_PhongTextBox.Text);
                cmd.Connection = conn;
                int value = (int)cmd.ExecuteScalar();
                conn.Close();
                if (value == 1)
                {
                    MessageBox.Show("Mã phòng không được trùng, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query = string.Format("INSERT INTO PHONG VALUES ('{0}', N'{1}', N'{2}', '{3}', N'Trống')", ma_PhongTextBox.Text, ten_PhongTextBox.Text, loai_PhongTextBox.Text, gia_PhongTextBox.Text);
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = query;
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Connection = conn;
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        

    }
}
