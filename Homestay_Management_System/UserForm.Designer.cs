namespace Homestay_Management_System
{
    partial class frm_UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserForm));
            this.Menu_Bar = new System.Windows.Forms.ToolStrip();
            this.btn_XemPhong = new System.Windows.Forms.ToolStripButton();
            this.btn_XemDichVu = new System.Windows.Forms.ToolStripButton();
            this.btn_DatPhong = new System.Windows.Forms.ToolStripButton();
            this.btn_DangXuat = new System.Windows.Forms.ToolStripButton();
            this.btn_HoSo = new System.Windows.Forms.ToolStripButton();
            this.pnl_Forms = new System.Windows.Forms.Panel();
            this.hOMESTAY_MANAGEMENTDataSet = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSet();
            this.tAI_KHOAN_APPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAI_KHOAN_APPTableAdapter = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TAI_KHOAN_APPTableAdapter();
            this.tableAdapterManager = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager();
            this.Menu_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAI_KHOAN_APPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_Bar
            // 
            this.Menu_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(224)))), ((int)(((byte)(28)))));
            this.Menu_Bar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_Bar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_XemPhong,
            this.btn_XemDichVu,
            this.btn_DatPhong,
            this.btn_DangXuat,
            this.btn_HoSo});
            this.Menu_Bar.Location = new System.Drawing.Point(0, 0);
            this.Menu_Bar.Name = "Menu_Bar";
            this.Menu_Bar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu_Bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu_Bar.Size = new System.Drawing.Size(1044, 46);
            this.Menu_Bar.Stretch = true;
            this.Menu_Bar.TabIndex = 2;
            // 
            // btn_XemPhong
            // 
            this.btn_XemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_XemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemPhong.ForeColor = System.Drawing.Color.White;
            this.btn_XemPhong.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemPhong.Image")));
            this.btn_XemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemPhong.ImageTransparentColor = System.Drawing.Color.Red;
            this.btn_XemPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XemPhong.Name = "btn_XemPhong";
            this.btn_XemPhong.Padding = new System.Windows.Forms.Padding(5);
            this.btn_XemPhong.Size = new System.Drawing.Size(117, 46);
            this.btn_XemPhong.Text = "Xem Phòng";
            this.btn_XemPhong.Click += new System.EventHandler(this.btn_XemPhong_Click);
            // 
            // btn_XemDichVu
            // 
            this.btn_XemDichVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_XemDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemDichVu.Image")));
            this.btn_XemDichVu.ImageTransparentColor = System.Drawing.Color.Red;
            this.btn_XemDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XemDichVu.Name = "btn_XemDichVu";
            this.btn_XemDichVu.Padding = new System.Windows.Forms.Padding(5);
            this.btn_XemDichVu.Size = new System.Drawing.Size(125, 46);
            this.btn_XemDichVu.Text = "Xem Dịch Vụ";
            this.btn_XemDichVu.Click += new System.EventHandler(this.btn_XemDichVu_Click);
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatPhong.ForeColor = System.Drawing.Color.White;
            this.btn_DatPhong.Image = ((System.Drawing.Image)(resources.GetObject("btn_DatPhong.Image")));
            this.btn_DatPhong.ImageTransparentColor = System.Drawing.Color.Red;
            this.btn_DatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Padding = new System.Windows.Forms.Padding(5);
            this.btn_DatPhong.Size = new System.Drawing.Size(111, 46);
            this.btn_DatPhong.Text = "Đặt phòng";
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Image")));
            this.btn_DangXuat.ImageTransparentColor = System.Drawing.Color.Red;
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Padding = new System.Windows.Forms.Padding(5);
            this.btn_DangXuat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_DangXuat.RightToLeftAutoMirrorImage = true;
            this.btn_DangXuat.Size = new System.Drawing.Size(46, 46);
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_HoSo
            // 
            this.btn_HoSo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_HoSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoSo.ForeColor = System.Drawing.Color.White;
            this.btn_HoSo.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoSo.Image")));
            this.btn_HoSo.ImageTransparentColor = System.Drawing.Color.Red;
            this.btn_HoSo.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_HoSo.Name = "btn_HoSo";
            this.btn_HoSo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_HoSo.Size = new System.Drawing.Size(75, 46);
            this.btn_HoSo.Text = "Hồ sơ";
            this.btn_HoSo.Click += new System.EventHandler(this.btn_HoSo_Click);
            // 
            // pnl_Forms
            // 
            this.pnl_Forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Forms.Location = new System.Drawing.Point(0, 46);
            this.pnl_Forms.Name = "pnl_Forms";
            this.pnl_Forms.Size = new System.Drawing.Size(1044, 468);
            this.pnl_Forms.TabIndex = 4;
            // 
            // hOMESTAY_MANAGEMENTDataSet
            // 
            this.hOMESTAY_MANAGEMENTDataSet.DataSetName = "HOMESTAY_MANAGEMENTDataSet";
            this.hOMESTAY_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAI_KHOAN_APPBindingSource
            // 
            this.tAI_KHOAN_APPBindingSource.DataMember = "TAI_KHOAN_APP";
            this.tAI_KHOAN_APPBindingSource.DataSource = this.hOMESTAY_MANAGEMENTDataSet;
            // 
            // tAI_KHOAN_APPTableAdapter
            // 
            this.tAI_KHOAN_APPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_HOA_DONTableAdapter = null;
            this.tableAdapterManager.DICH_VUTableAdapter = null;
            this.tableAdapterManager.HOA_DON_THANH_TOANTableAdapter = null;
            this.tableAdapterManager.KH_DUNG_DVTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.NHAN_VIEN_QL_PHONGTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAI_KHOAN_APPTableAdapter = this.tAI_KHOAN_APPTableAdapter;
            this.tableAdapterManager.THUETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1044, 514);
            this.Controls.Add(this.pnl_Forms);
            this.Controls.Add(this.Menu_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_UserForm_Load);
            this.Menu_Bar.ResumeLayout(false);
            this.Menu_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAI_KHOAN_APPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip Menu_Bar;
        private System.Windows.Forms.ToolStripButton btn_XemPhong;
        private System.Windows.Forms.ToolStripButton btn_XemDichVu;
        private System.Windows.Forms.ToolStripButton btn_DatPhong;
        private System.Windows.Forms.ToolStripButton btn_DangXuat;
        private System.Windows.Forms.ToolStripButton btn_HoSo;
        private System.Windows.Forms.Panel pnl_Forms;
        private HOMESTAY_MANAGEMENTDataSet hOMESTAY_MANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource tAI_KHOAN_APPBindingSource;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.TAI_KHOAN_APPTableAdapter tAI_KHOAN_APPTableAdapter;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}