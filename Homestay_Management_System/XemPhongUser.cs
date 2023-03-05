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
    public partial class frm_XemPhongUser : Form
    {
        public frm_XemPhongUser()
        {
            InitializeComponent();
        }

        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hOMESTAY_MANAGEMENTDataSet);

        }

        private void frm_XemPhongUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOMESTAY_MANAGEMENTDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.hOMESTAY_MANAGEMENTDataSet.PHONG);

        }
    }
}
