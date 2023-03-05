namespace Homestay_Management_System
{
    partial class frm_XemPhongUser
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
            this.hOMESTAY_MANAGEMENTDataSet = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSet();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.PHONGTableAdapter();
            this.tableAdapterManager = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager();
            this.pHONGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hOMESTAY_MANAGEMENTDataSet
            // 
            this.hOMESTAY_MANAGEMENTDataSet.DataSetName = "HOMESTAY_MANAGEMENTDataSet";
            this.hOMESTAY_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.hOMESTAY_MANAGEMENTDataSet;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PHONGTableAdapter = this.pHONGTableAdapter;
            this.tableAdapterManager.TAI_KHOAN_APPTableAdapter = null;
            this.tableAdapterManager.THUETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHONGDataGridView
            // 
            this.pHONGDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHONGDataGridView.AutoGenerateColumns = false;
            this.pHONGDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pHONGDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.pHONGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pHONGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pHONGDataGridView.DataSource = this.pHONGBindingSource;
            this.pHONGDataGridView.Location = new System.Drawing.Point(68, 104);
            this.pHONGDataGridView.Name = "pHONGDataGridView";
            this.pHONGDataGridView.Size = new System.Drawing.Size(654, 220);
            this.pHONGDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ma_Phong";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phòng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ten_Phong";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Phòng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Loai_Phong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Loại Phòng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gia_Phong";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá Phòng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Trang_Thai_Phong";
            this.dataGridViewTextBoxColumn5.HeaderText = "Trạng Thái Phòng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frm_XemPhongUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pHONGDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_XemPhongUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "XemPhongUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_XemPhongUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HOMESTAY_MANAGEMENTDataSet hOMESTAY_MANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pHONGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}