using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homestay_Management_System
{
    public partial class frm_ReceptionForm : Form
    {
        string tenDN, MatKhau;

        public frm_ReceptionForm()
        {
            InitializeComponent();
        }
       

        public frm_ReceptionForm(string tenDN, string matKhau) : this()
        {
            this.tenDN = tenDN;
            this.MatKhau = matKhau;
        }

        private void btn_XemPhong_Click(object sender, EventArgs e)
        {
            frm_XemPhong XP = new frm_XemPhong();
            XP.TopLevel = false;
            pnl_Forms.Controls.Add(XP);
            XP.Show();
        }

        private void frm_ReceptionForm_Load(object sender, EventArgs e)
        {
            this.btn_HoSo.Text = tenDN;

        }

        private void btn_HoSo_Click(object sender, EventArgs e)
        {
            frm_HoSo HS = new frm_HoSo(tenDN, MatKhau);
            HS.TopLevel = false;
            pnl_Forms.Controls.Add(HS);
            HS.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (dlr == DialogResult.OK)
                Application.Exit();
        }
    }
}
