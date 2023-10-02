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
    public partial class frm_XemDichVu_Admin_Reception : Form
    {
        public frm_XemDichVu_Admin_Reception()
        {
            InitializeComponent();
        }

        string connect = global::Homestay_Management_System.Properties.Settings.Default.HOMESTAY_MANAGEMENTConnectionString;
        SqlConnection conn;

        BindingSource bs = new BindingSource();

        private void frm_XemDichVu_Admin_Reception_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DICH_VU", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns[0].ColumnName= "Mã Dịch Vụ";
            dt.Columns[1].ColumnName = "Tên Dịch Vụ";
            dt.Columns[2].ColumnName = "Giá Dịch Vụ";
            bs.DataSource = dt;
            dtg_DichVu.DataSource = bs;
            dtg_DichVu.Columns[0].Visible= false;
        }

        private void dtg_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            DataGridViewRow chon = this.dtg_DichVu.Rows[vt];
            txt_TenDV.Text = chon.Cells[1].Value.ToString();
            txt_GiaDV.Text = chon.Cells[2].Value.ToString();
        }

        private void txt_GiaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO DICH_VU VALUES (N'" + txt_TenDV.Text + "', " + float.Parse(txt_GiaDV.Text) + ")", conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                DataTable dt = (DataTable)bs.DataSource;
                DataRow row = dt.NewRow();
                row[1] = txt_TenDV.Text;
                row[2] = txt_GiaDV.Text;
                dt.Rows.Add(row);
                MessageBox.Show("Thêm mới thành công", "Thông báo");
            }
            else
                MessageBox.Show("Không thể thêm mới", "Thông báo");
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng hiện tại không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int MaDV = (int)dtg_DichVu.CurrentRow.Cells[0].Value;
                SqlCommand cmd = new SqlCommand("DELETE DICH_VU WHERE Ma_DV = " + MaDV, conn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    DataRowView row = (DataRowView)bs.Current;
                    row.Delete();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Không thể xóa dòng ghi hiện thời", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            int MaDV = (int)dtg_DichVu.CurrentRow.Cells[0].Value;
            string query = string.Format("UPDATE DICH_VU SET Ten_DV = N'{0}', Gia_DV = {1} WHERE Ma_DV = '{2}'", txt_TenDV.Text, float.Parse(txt_GiaDV.Text), MaDV);
            SqlCommand cmd = new SqlCommand(query, conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                DataRowView row = (DataRowView)bs.Current;
                row[1] = txt_TenDV.Text;
                row[2] = txt_GiaDV.Text;
                bs.ResetCurrentItem();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Không sửa được !", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
