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
    public partial class frm_UserForm : Form
    {
        string tenDN, MatKhau;
    
        public frm_UserForm()
        {
            InitializeComponent();
        }

        public frm_UserForm(string tenDN, string matKhau) : this()
        {
            this.tenDN = tenDN;
            this.MatKhau = matKhau;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (dlr == DialogResult.OK)
                Application.Exit();
        }

        private void btn_XemPhong_Click(object sender, EventArgs e)
        {
            frm_XemPhongUser XPU = new frm_XemPhongUser();
            XPU.TopLevel = false;
            pnl_Forms.Controls.Add(XPU);
            XPU.Show();
        }

        private void btn_XemDichVu_Click(object sender, EventArgs e)
        {
            frm_XemDichVu DV = new frm_XemDichVu();
            DV.TopLevel = false;
            pnl_Forms.Controls.Add(DV);
            DV.Show();
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            frm_DatPhong DP = new frm_DatPhong();
            DP.TopLevel = false;
            pnl_Forms.Controls.Add(DP);
            DP.Show();
        }

        private void btn_HoSo_Click(object sender, EventArgs e)
        {
            frm_HoSo HS = new frm_HoSo(tenDN, MatKhau);
            HS.TopLevel = false;
            pnl_Forms.Controls.Add(HS);
            HS.Show();
        }

        private void tAI_KHOAN_APPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAI_KHOAN_APPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOMESTAY_MANAGEMENTDataSet);

        }

        private void frm_UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOMESTAY_MANAGEMENTDataSet.TAI_KHOAN_APP' table. You can move, or remove it, as needed.
            this.tAI_KHOAN_APPTableAdapter.Fill(this.hOMESTAY_MANAGEMENTDataSet.TAI_KHOAN_APP);
            this.btn_HoSo.Text = tenDN;
        }
    }
       
}
