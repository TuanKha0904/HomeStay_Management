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
            this.pnl_ChinhSua = new System.Windows.Forms.Panel();
            this.btn_SaveImage = new System.Windows.Forms.Button();
            this.btn_ChinhSua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.ma_PhongTextBox = new System.Windows.Forms.TextBox();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOMESTAY_MANAGEMENTDataSet = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSet();
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
            loai_PhongLabel = new System.Windows.Forms.Label();
            ten_PhongLabel = new System.Windows.Forms.Label();
            gia_PhongLabel = new System.Windows.Forms.Label();
            lb_MaPhong = new System.Windows.Forms.Label();
            this.pnl_Xem.SuspendLayout();
            this.pnl_ChinhSua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loai_PhongLabel
            // 
            loai_PhongLabel.AutoSize = true;
            loai_PhongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loai_PhongLabel.Location = new System.Drawing.Point(28, 105);
            loai_PhongLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loai_PhongLabel.Name = "loai_PhongLabel";
            loai_PhongLabel.Size = new System.Drawing.Size(128, 25);
            loai_PhongLabel.TabIndex = 1;
            loai_PhongLabel.Text = "Loại Phòng:";
            // 
            // ten_PhongLabel
            // 
            ten_PhongLabel.AutoSize = true;
            ten_PhongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ten_PhongLabel.Location = new System.Drawing.Point(28, 182);
            ten_PhongLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ten_PhongLabel.Name = "ten_PhongLabel";
            ten_PhongLabel.Size = new System.Drawing.Size(125, 25);
            ten_PhongLabel.TabIndex = 3;
            ten_PhongLabel.Text = "Tên Phòng:";
            // 
            // gia_PhongLabel
            // 
            gia_PhongLabel.AutoSize = true;
            gia_PhongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gia_PhongLabel.Location = new System.Drawing.Point(28, 251);
            gia_PhongLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gia_PhongLabel.Name = "gia_PhongLabel";
            gia_PhongLabel.Size = new System.Drawing.Size(120, 25);
            gia_PhongLabel.TabIndex = 5;
            gia_PhongLabel.Text = "Giá Phòng:";
            // 
            // lb_MaPhong
            // 
            lb_MaPhong.AutoSize = true;
            lb_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_MaPhong.Location = new System.Drawing.Point(28, 34);
            lb_MaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_MaPhong.Name = "lb_MaPhong";
            lb_MaPhong.Size = new System.Drawing.Size(117, 25);
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
            this.pnl_Xem.Location = new System.Drawing.Point(0, 75);
            this.pnl_Xem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Xem.Name = "pnl_Xem";
            this.pnl_Xem.Size = new System.Drawing.Size(1352, 849);
            this.pnl_Xem.TabIndex = 0;
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
            this.pnl_ChinhSua.Location = new System.Drawing.Point(291, 0);
            this.pnl_ChinhSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_ChinhSua.Name = "pnl_ChinhSua";
            this.pnl_ChinhSua.Size = new System.Drawing.Size(771, 402);
            this.pnl_ChinhSua.TabIndex = 15;
            // 
            // btn_SaveImage
            // 
            this.btn_SaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveImage.FlatAppearance.BorderSize = 0;
            this.btn_SaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveImage.Image")));
            this.btn_SaveImage.Location = new System.Drawing.Point(573, 285);
            this.btn_SaveImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SaveImage.Name = "btn_SaveImage";
            this.btn_SaveImage.Size = new System.Drawing.Size(58, 62);
            this.btn_SaveImage.TabIndex = 13;
            this.btn_SaveImage.UseVisualStyleBackColor = false;
            this.btn_SaveImage.Click += new System.EventHandler(this.btn_SaveImage_Click);
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(12)))), ((int)(((byte)(241)))), ((int)(((byte)(1)))));
            this.btn_ChinhSua.Location = new System.Drawing.Point(518, 28);
            this.btn_ChinhSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(168, 37);
            this.btn_ChinhSua.TabIndex = 7;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.UseVisualStyleBackColor = false;
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(12)))), ((int)(((byte)(241)))), ((int)(((byte)(1)))));
            this.btn_Luu.Location = new System.Drawing.Point(518, 98);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(168, 37);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(12)))), ((int)(((byte)(241)))), ((int)(((byte)(1)))));
            this.btn_Xoa.Location = new System.Drawing.Point(518, 169);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(168, 37);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(12)))), ((int)(((byte)(241)))), ((int)(((byte)(1)))));
            this.btn_ThemPhong.Location = new System.Drawing.Point(518, 238);
            this.btn_ThemPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(168, 37);
            this.btn_ThemPhong.TabIndex = 11;
            this.btn_ThemPhong.Text = "Thêm Phòng";
            this.btn_ThemPhong.UseVisualStyleBackColor = false;
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // ma_PhongTextBox
            // 
            this.ma_PhongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ma_PhongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ma_PhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "Ma_Phong", true));
            this.ma_PhongTextBox.Location = new System.Drawing.Point(226, 34);
            this.ma_PhongTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ma_PhongTextBox.MaxLength = 100;
            this.ma_PhongTextBox.Name = "ma_PhongTextBox";
            this.ma_PhongTextBox.Size = new System.Drawing.Size(212, 23);
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
            // gia_PhongTextBox
            // 
            this.gia_PhongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gia_PhongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gia_PhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "Gia_Phong", true));
            this.gia_PhongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia_PhongTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gia_PhongTextBox.Location = new System.Drawing.Point(226, 250);
            this.gia_PhongTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gia_PhongTextBox.MaxLength = 100;
            this.gia_PhongTextBox.Name = "gia_PhongTextBox";
            this.gia_PhongTextBox.Size = new System.Drawing.Size(212, 23);
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
            this.ten_PhongTextBox.Location = new System.Drawing.Point(226, 181);
            this.ten_PhongTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ten_PhongTextBox.MaxLength = 100;
            this.ten_PhongTextBox.Name = "ten_PhongTextBox";
            this.ten_PhongTextBox.Size = new System.Drawing.Size(212, 23);
            this.ten_PhongTextBox.TabIndex = 4;
            // 
            // loai_PhongTextBox
            // 
            this.loai_PhongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loai_PhongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loai_PhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "Loai_Phong", true));
            this.loai_PhongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loai_PhongTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loai_PhongTextBox.Location = new System.Drawing.Point(226, 105);
            this.loai_PhongTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loai_PhongTextBox.MaxLength = 100;
            this.loai_PhongTextBox.Name = "loai_PhongTextBox";
            this.loai_PhongTextBox.Size = new System.Drawing.Size(212, 23);
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
            this.pHONGDataGridView.Location = new System.Drawing.Point(76, 409);
            this.pHONGDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pHONGDataGridView.Name = "pHONGDataGridView";
            this.pHONGDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.pHONGDataGridView.Size = new System.Drawing.Size(1167, 338);
            this.pHONGDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ma_Phong";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phòng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ten_Phong";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Phòng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Loai_Phong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Loại Phòng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gia_Phong";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá Phòng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Trang_Thai_Phong";
            this.dataGridViewTextBoxColumn5.HeaderText = "Trạng Thái Phòng";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
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
            // frm_XemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1352, 888);
            this.Controls.Add(this.pnl_Xem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_XemPhong";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_XemPhong_Load);
            this.pnl_Xem.ResumeLayout(false);
            this.pnl_ChinhSua.ResumeLayout(false);
            this.pnl_ChinhSua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGDataGridView)).EndInit();
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