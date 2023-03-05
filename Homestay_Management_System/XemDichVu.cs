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
    public partial class frm_XemDichVu : Form
    {
        public frm_XemDichVu()
        {
            InitializeComponent();
        }

        private void dICH_VUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dICH_VUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOMESTAY_MANAGEMENTDataSet);

        }

        private void frm_XemDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOMESTAY_MANAGEMENTDataSet.DICH_VU' table. You can move, or remove it, as needed.
            this.dICH_VUTableAdapter.Fill(this.hOMESTAY_MANAGEMENTDataSet.DICH_VU);

        }
    }
}
