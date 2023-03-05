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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_TenDV.Text = dtg_DichVu.CurrentRow.Cells["Ten_DV"].Value.ToString();
                txt_GiaDV.Text = dtg_DichVu.CurrentRow.Cells["Gia_DV"].Value.ToString();
            }
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
            SqlCommand cmd = new SqlCommand("INSERT INTO DICH_VU VALUES(N'" + txt_TenDV.Text + "', " + float.Parse(txt_GiaDV.Text) + "')", conn);
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
    }
}
