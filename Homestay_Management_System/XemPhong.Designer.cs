namespace Homestay_Management_System
{
    partial class frm_XemPhong
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
            System.Windows.Forms.Label loai_PhongLabel;
            System.Windows.Forms.Label ten_PhongLabel;
            System.Windows.Forms.Label gia_PhongLabel;
            System.Windows.Forms.Label lb_MaPhong;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_XemPhong));
            this.pnl_Xem = new System.Windows.Forms.Panel();
            this.btn_SaveImage = new System.Windows.Forms.Button();
            this.ma_PhongTextBox = new System.Windows.Forms.TextBox();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOMESTAY_MANAGEMENTDataSet = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSet();
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_ChinhSua = new System.Windows.Forms.Button();
            this.gia_PhongTextBox = new System.Windows.Forms.TextBox();
            this.ten_PhongTextBox = new System.Windows.Forms.TextBox();
            this.loai_PhongTextBox = new System.Windows.Forms.TextBox();
            this.pHONGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONGTableAdapter = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.PHONGTableAdapter();
            this.tableAdapterManager = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager();
            this.pnl_ChinhSua = new System.Windows.Forms.Panel();
            loai_PhongLabel = new System.Windows.Forms.Label();
            ten_PhongLabel = new System.Windows.Forms.Label();
            gia_PhongLabel = new System.Windows.Forms.Label();
            lb_MaPhong = new System.Windows.Forms.Label();
            this.pnl_Xem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGDataGridView)).BeginInit();
            this.pnl_ChinhSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // loai_PhongLabel
            // 
            loai_PhongLabel.AutoSize = true;
            loai_PhongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loai_PhongLabel.Location = new System.Drawing.Point(10, 68);
            loai_PhongLabel.Name = "loai_PhongLabel";
            loai_PhongLabel.Size = new System.Drawing.Size(89, 16);
            loai_PhongLabel.TabIndex = 1;
            loai_PhongLabel.Text = "Loại Phòng:";
            // 
            // ten_PhongLabel
            // 
            ten_PhongLabel.AutoSize = true;
            ten_PhongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ten_PhongLabel.Location = new System.Drawing.Point(13, 118);
            ten_PhongLabel.Name = "ten_PhongLabel";
            ten_PhongLabel.Size = new System.Drawing.Size(86, 16);
            ten_PhongLabel.TabIndex = 3;
            ten_PhongLabel.Text = "Tên Phòng:";
            // 
            // gia_PhongLabel
            // 
            gia_PhongLabel.AutoSize = true;
            gia_PhongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gia_PhongLabel.Location = new System.Drawing.Point(16, 163);
            gia_PhongLabel.Name = "gia_PhongLabel";
            gia_PhongLabel.Size = new System.Drawing.Size(83, 16);
            gia_PhongLabel.TabIndex = 5;
            gia_PhongLabel.Text = "Giá Phòng:";
            // 
            // lb_MaPhong
            // 
            lb_MaPhong.AutoSize = true;
            lb_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_MaPhong.Location = new System.Drawing.Point(19, 22);
            lb_MaPhong.Name = "lb_MaPhong";
            lb_MaPhong.Size = new System.Drawing.Size(80, 16);
            lb_MaPhong.TabIndex = 14;
            lb_MaPhong.Text = "Mã Phòng:";
            // 
            // pnl_Xem
            // 
            this.pnl_Xem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Xem.Controls.Add(this.pnl_ChinhSua);
            this.pnl_Xem.Controls.Add(this.pHONGDataGridView);
            this.pnl_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Xem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_Xem.Location = new System.Drawing.Point(0, 49);
            this.pnl_Xem.Name = "pnl_Xem";
            this.pnl_Xem.Size = new System.Drawing.Size(901, 552);
            this.pnl_Xem.TabIndex = 0;
            // 
            // btn_SaveImage
            // 
            this.btn_SaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveImage.FlatAppearance.BorderSize = 0;
            this.btn_SaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveImage.Image")));
            this.btn_SaveImage.Location = new System.Drawing.Point(382, 185);
            this.btn_SaveImage.Name = "btn_SaveImage";
            this.btn_SaveImage.Size = new System.Drawing.Size(39, 40);
            this.btn_SaveImage.TabIndex = 13;
            this.btn_SaveImage.UseVisualStyleBackColor = false;
            this.btn_SaveImage.Click += new System.EventHandler(this.btn_SaveImage_Click);
            // 
            // ma_PhongTextBox
            // 
            this.ma_PhongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ma_PhongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ma_PhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "Ma_Phong", true));
            this.ma_PhongTextBox.Location = new System.Drawing.Point(118, 23);
            this.ma_PhongTextBox.MaxLength = 100;
            this.ma_PhongTextBox.Name = "ma_PhongTextBox";
            this.ma_PhongTextBox.Size = new System.Drawing.Size(141, 15);
            this.ma_PhongTextBox.TabIndex = 12;
            this.ma_PhongTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ma_PhongTextBox_KeyPress);
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.hOMESTAY_MANAGEMENTDataSet;
            // 
            // hOMESTAY_MANAGEMENTDataSet
            // 
            this.hOMESTAY_MANAGEMENTDataSet.DataSetName = "HOMESTAY_MANAGEMENTDataSet";
            this.hOMESTAY_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(12)))), ((int)(((byte)(241)))), ((int)(((byte)(1)))));
            this.btn_ThemPhong.Location = new System.Drawing.Point(345, 155);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(112, 24);
            this.btn_ThemPhong.TabIndex = 11;
            this.btn_ThemPhong.Text = "Thêm Phòng";
            this.btn_ThemPhong.UseVisualStyleBackColor = false;
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(12)))), ((int)(((byte)(241)))), ((int)(((byte)(1)))));
            this.btn_Xoa.Location = new System.Drawing.Point(345, 110);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(112, 24);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(12)))), ((int)(((byte)(241)))), ((int)(((byte)(1)))));
            this.btn_Luu.Location = new System.Drawing.Point(345, 64);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(112, 24);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(12)))), ((int)(((byte)(241)))), ((int)(((byte)(1)))));
            this.btn_ChinhSua.Location = new System.Drawing.Point(345, 18);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(112, 24);
            this.btn_ChinhSua.TabIndex = 7;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.UseVisualStyleBackColor = false;
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // gia_PhongTextBox
            // 
            this.gia_PhongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gia_PhongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gia_PhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "Gia_Phong", true));
            this.gia_PhongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia_PhongTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gia_PhongTextBox.Location = new System.Drawing.Point(118, 163);
            this.gia_PhongTextBox.MaxLength = 100;
            this.gia_PhongTextBox.Name = "gia_PhongTextBox";
            this.gia_PhongTextBox.Size = new System.Drawing.Size(141, 15);
            this.gia_PhongTextBox.TabIndex = 6;
            this.gia_PhongTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gia_PhongTextBox_KeyPress);
            // 
            // ten_PhongTextBox
            // 
            this.ten_PhongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ten_PhongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ten_PhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "Ten_Phong", true));
            this.ten_PhongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_PhongTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ten_PhongTextBox.Location = new System.Drawing.Point(118, 118);
            this.ten_PhongTextBox.MaxLength = 100;
            this.ten_PhongTextBox.Name = "ten_PhongTextBox";
            this.ten_PhongTextBox.Size = new System.Drawing.Size(141, 15);
            this.ten_PhongTextBox.TabIndex = 4;
            // 
            // loai_PhongTextBox
            // 
            this.loai_PhongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loai_PhongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loai_PhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "Loai_Phong", true));
            this.loai_PhongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loai_PhongTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loai_PhongTextBox.Location = new System.Drawing.Point(118, 69);
            this.loai_PhongTextBox.MaxLength = 100;
            this.loai_PhongTextBox.Name = "loai_PhongTextBox";
            this.loai_PhongTextBox.Size = new System.Drawing.Size(141, 15);
            this.loai_PhongTextBox.TabIndex = 2;
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
            this.pHONGDataGridView.Location = new System.Drawing.Point(51, 266);
            this.pHONGDataGridView.Name = "pHONGDataGridView";
            this.pHONGDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.pHONGDataGridView.Size = new System.Drawing.Size(778, 220);
            this.pHONGDataGridView.TabIndex = 0;
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
            // pnl_ChinhSua
            // 
            this.pnl_ChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ChinhSua.Controls.Add(gia_PhongLabel);
            this.pnl_ChinhSua.Controls.Add(this.btn_SaveImage);
            this.pnl_ChinhSua.Controls.Add(lb_MaPhong);
            this.pnl_ChinhSua.Controls.Add(this.btn_ChinhSua);
            this.pnl_ChinhSua.Controls.Add(this.btn_Luu);
            this.pnl_ChinhSua.Controls.Add(this.btn_Xoa);
            this.pnl_ChinhSua.Controls.Add(this.btn_ThemPhong);
            this.pnl_ChinhSua.Controls.Add(this.ma_PhongTextBox);
            this.pnl_ChinhSua.Controls.Add(ten_PhongLabel);
            this.pnl_ChinhSua.Controls.Add(loai_PhongLabel);
            this.pnl_ChinhSua.Controls.Add(this.gia_PhongTextBox);
            this.pnl_ChinhSua.Controls.Add(this.ten_PhongTextBox);
            this.pnl_ChinhSua.Controls.Add(this.loai_PhongTextBox);
            this.pnl_ChinhSua.Location = new System.Drawing.Point(194, 0);
            this.pnl_ChinhSua.Name = "pnl_ChinhSua";
            this.pnl_ChinhSua.Size = new System.Drawing.Size(514, 261);
            this.pnl_ChinhSua.TabIndex = 15;
            // 
            // frm_XemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(901, 577);
            this.Controls.Add(this.pnl_Xem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_XemPhong";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_XemPhong_Load);
            this.pnl_Xem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGDataGridView)).EndInit();
            this.pnl_ChinhSua.ResumeLayout(false);
            this.pnl_ChinhSua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Xem;
        private HOMESTAY_MANAGEMENTDataSet hOMESTAY_MANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox gia_PhongTextBox;
        private System.Windows.Forms.TextBox ten_PhongTextBox;
        private System.Windows.Forms.TextBox loai_PhongTextBox;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_ChinhSua;
        public System.Windows.Forms.DataGridView pHONGDataGridView;
        private System.Windows.Forms.Button btn_ThemPhong;
        private System.Windows.Forms.Button btn_SaveImage;
        private System.Windows.Forms.TextBox ma_PhongTextBox;
        private System.Windows.Forms.Panel pnl_ChinhSua;
    }
}