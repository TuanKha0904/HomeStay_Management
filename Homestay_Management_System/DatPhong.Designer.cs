namespace Homestay_Management_System
{
    partial class frm_DatPhong
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
            System.Windows.Forms.Label ma_PhongLabel;
            this.tHUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grb_Thue = new System.Windows.Forms.GroupBox();
            this.gb_ThongTin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.txt_QuocTich = new System.Windows.Forms.TextBox();
            this.txt_SoCMT = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.kHACH_HANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOMESTAY_MANAGEMENTDataSet = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSet();
            this.kHACH_HANGTableAdapter = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.KHACH_HANGTableAdapter();
            this.tableAdapterManager = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager();
            this.tHUETableAdapter = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.THUETableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_NgayThue = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.btn_Thue = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.tHUEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.PHONGTableAdapter();
            this.ma_PhongComboBox = new System.Windows.Forms.ComboBox();
            ma_PhongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tHUEBindingSource)).BeginInit();
            this.grb_Thue.SuspendLayout();
            this.gb_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACH_HANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tHUEBindingSource
            // 
            this.tHUEBindingSource.DataMember = "FK__THUE__Ma_KH__5BE2A6F2";
            this.tHUEBindingSource.DataSource = this.kHACH_HANGBindingSource;
            // 
            // grb_Thue
            // 
            this.grb_Thue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Thue.BackColor = System.Drawing.Color.DodgerBlue;
            this.grb_Thue.Controls.Add(ma_PhongLabel);
            this.grb_Thue.Controls.Add(this.ma_PhongComboBox);
            this.grb_Thue.Controls.Add(this.btn_Huy);
            this.grb_Thue.Controls.Add(this.btn_Thue);
            this.grb_Thue.Controls.Add(this.dtp_NgayTra);
            this.grb_Thue.Controls.Add(this.dtp_NgayThue);
            this.grb_Thue.Controls.Add(this.label8);
            this.grb_Thue.Controls.Add(this.label7);
            this.grb_Thue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Thue.ForeColor = System.Drawing.Color.Navy;
            this.grb_Thue.Location = new System.Drawing.Point(755, 23);
            this.grb_Thue.Name = "grb_Thue";
            this.grb_Thue.Size = new System.Drawing.Size(545, 304);
            this.grb_Thue.TabIndex = 3;
            this.grb_Thue.TabStop = false;
            this.grb_Thue.Text = "Thuê";
            // 
            // gb_ThongTin
            // 
            this.gb_ThongTin.BackColor = System.Drawing.Color.DodgerBlue;
            this.gb_ThongTin.Controls.Add(this.btn_Luu);
            this.gb_ThongTin.Controls.Add(this.txt_SDT);
            this.gb_ThongTin.Controls.Add(this.txt_SoCMT);
            this.gb_ThongTin.Controls.Add(this.txt_QuocTich);
            this.gb_ThongTin.Controls.Add(this.cbb_GioiTinh);
            this.gb_ThongTin.Controls.Add(this.dtp_NgaySinh);
            this.gb_ThongTin.Controls.Add(this.txt_HoTen);
            this.gb_ThongTin.Controls.Add(this.label6);
            this.gb_ThongTin.Controls.Add(this.label5);
            this.gb_ThongTin.Controls.Add(this.label4);
            this.gb_ThongTin.Controls.Add(this.label3);
            this.gb_ThongTin.Controls.Add(this.label2);
            this.gb_ThongTin.Controls.Add(this.label1);
            this.gb_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ThongTin.ForeColor = System.Drawing.Color.Navy;
            this.gb_ThongTin.Location = new System.Drawing.Point(73, 23);
            this.gb_ThongTin.Name = "gb_ThongTin";
            this.gb_ThongTin.Size = new System.Drawing.Size(498, 304);
            this.gb_ThongTin.TabIndex = 4;
            this.gb_ThongTin.TabStop = false;
            this.gb_ThongTin.Text = "Thông tin";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số CMT:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quốc Tịch:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_HoTen.Location = new System.Drawing.Point(154, 24);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(213, 22);
            this.txt_HoTen.TabIndex = 6;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(154, 67);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(213, 22);
            this.dtp_NgaySinh.TabIndex = 7;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_GioiTinh.Location = new System.Drawing.Point(154, 110);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(213, 24);
            this.cbb_GioiTinh.TabIndex = 8;
            // 
            // txt_QuocTich
            // 
            this.txt_QuocTich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_QuocTich.Location = new System.Drawing.Point(154, 159);
            this.txt_QuocTich.Name = "txt_QuocTich";
            this.txt_QuocTich.Size = new System.Drawing.Size(213, 22);
            this.txt_QuocTich.TabIndex = 9;
            // 
            // txt_SoCMT
            // 
            this.txt_SoCMT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SoCMT.Location = new System.Drawing.Point(154, 205);
            this.txt_SoCMT.Name = "txt_SoCMT";
            this.txt_SoCMT.Size = new System.Drawing.Size(213, 22);
            this.txt_SoCMT.TabIndex = 10;
            this.txt_SoCMT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoCMT_KeyPress);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SDT.Location = new System.Drawing.Point(154, 252);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(213, 22);
            this.txt_SDT.TabIndex = 11;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoCMT_KeyPress);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Location = new System.Drawing.Point(405, 128);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 53);
            this.btn_Luu.TabIndex = 12;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // kHACH_HANGBindingSource
            // 
            this.kHACH_HANGBindingSource.DataMember = "KHACH_HANG";
            this.kHACH_HANGBindingSource.DataSource = this.hOMESTAY_MANAGEMENTDataSet;
            // 
            // hOMESTAY_MANAGEMENTDataSet
            // 
            this.hOMESTAY_MANAGEMENTDataSet.DataSetName = "HOMESTAY_MANAGEMENTDataSet";
            this.hOMESTAY_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACH_HANGTableAdapter
            // 
            this.kHACH_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_HOA_DONTableAdapter = null;
            this.tableAdapterManager.DICH_VUTableAdapter = null;
            this.tableAdapterManager.HOA_DON_THANH_TOANTableAdapter = null;
            this.tableAdapterManager.KH_DUNG_DVTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = this.kHACH_HANGTableAdapter;
            this.tableAdapterManager.NHAN_VIEN_QL_PHONGTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAI_KHOAN_APPTableAdapter = null;
            this.tableAdapterManager.THUETableAdapter = this.tHUETableAdapter;
            this.tableAdapterManager.UpdateOrder = Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tHUETableAdapter
            // 
            this.tHUETableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày Thuê:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày Trả:";
            // 
            // dtp_NgayThue
            // 
            this.dtp_NgayThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayThue.Location = new System.Drawing.Point(165, 108);
            this.dtp_NgayThue.MinDate = new System.DateTime(2023, 3, 4, 11, 8, 17, 0);
            this.dtp_NgayThue.Name = "dtp_NgayThue";
            this.dtp_NgayThue.Size = new System.Drawing.Size(200, 22);
            this.dtp_NgayThue.TabIndex = 4;
            this.dtp_NgayThue.Value = new System.DateTime(2023, 3, 4, 11, 8, 17, 0);
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTra.Location = new System.Drawing.Point(165, 166);
            this.dtp_NgayTra.MinDate = new System.DateTime(2023, 3, 4, 11, 8, 24, 0);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(200, 22);
            this.dtp_NgayTra.TabIndex = 5;
            this.dtp_NgayTra.Value = new System.DateTime(2023, 3, 4, 11, 8, 24, 0);
            // 
            // btn_Thue
            // 
            this.btn_Thue.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Thue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thue.Location = new System.Drawing.Point(165, 236);
            this.btn_Thue.Name = "btn_Thue";
            this.btn_Thue.Size = new System.Drawing.Size(75, 38);
            this.btn_Thue.TabIndex = 6;
            this.btn_Thue.Text = "Thuê";
            this.btn_Thue.UseVisualStyleBackColor = false;
            this.btn_Thue.Click += new System.EventHandler(this.btn_Thue_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Location = new System.Drawing.Point(290, 236);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 38);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // tHUEDataGridView
            // 
            this.tHUEDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tHUEDataGridView.AutoGenerateColumns = false;
            this.tHUEDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tHUEDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tHUEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tHUEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.tHUEDataGridView.DataSource = this.tHUEBindingSource;
            this.tHUEDataGridView.Location = new System.Drawing.Point(334, 333);
            this.tHUEDataGridView.Name = "tHUEDataGridView";
            this.tHUEDataGridView.Size = new System.Drawing.Size(672, 220);
            this.tHUEDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ma_KH";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ma_KH";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Ma_Phong";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã Phòng";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ngay_Thue";
            this.dataGridViewTextBoxColumn10.HeaderText = "Ngày Thuê";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Ngay_Tra";
            this.dataGridViewTextBoxColumn11.HeaderText = "Ngày Trả";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Thanh_Tien";
            this.dataGridViewTextBoxColumn12.HeaderText = "Thành Tiền";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Tien_Tra_Truoc";
            this.dataGridViewTextBoxColumn13.HeaderText = "Tiền trả trước";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
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
            // ma_PhongLabel
            // 
            ma_PhongLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            ma_PhongLabel.AutoSize = true;
            ma_PhongLabel.Location = new System.Drawing.Point(40, 49);
            ma_PhongLabel.Name = "ma_PhongLabel";
            ma_PhongLabel.Size = new System.Drawing.Size(80, 16);
            ma_PhongLabel.TabIndex = 7;
            ma_PhongLabel.Text = "Mã Phòng:";
            // 
            // ma_PhongComboBox
            // 
            this.ma_PhongComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ma_PhongComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "Ma_Phong", true));
            this.ma_PhongComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pHONGBindingSource, "Ma_Phong", true));
            this.ma_PhongComboBox.FormattingEnabled = true;
            this.ma_PhongComboBox.Location = new System.Drawing.Point(161, 46);
            this.ma_PhongComboBox.Name = "ma_PhongComboBox";
            this.ma_PhongComboBox.Size = new System.Drawing.Size(204, 24);
            this.ma_PhongComboBox.TabIndex = 8;
            // 
            // frm_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(155)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1386, 623);
            this.Controls.Add(this.tHUEDataGridView);
            this.Controls.Add(this.gb_ThongTin);
            this.Controls.Add(this.grb_Thue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DatPhong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tHUEBindingSource)).EndInit();
            this.grb_Thue.ResumeLayout(false);
            this.grb_Thue.PerformLayout();
            this.gb_ThongTin.ResumeLayout(false);
            this.gb_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACH_HANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HOMESTAY_MANAGEMENTDataSet hOMESTAY_MANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource kHACH_HANGBindingSource;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.KHACH_HANGTableAdapter kHACH_HANGTableAdapter;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.THUETableAdapter tHUETableAdapter;
        private System.Windows.Forms.BindingSource tHUEBindingSource;
        private System.Windows.Forms.GroupBox grb_Thue;
        private System.Windows.Forms.GroupBox gb_ThongTin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_SoCMT;
        private System.Windows.Forms.TextBox txt_QuocTich;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.DateTimePicker dtp_NgayThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Thue;
        private System.Windows.Forms.DataGridView tHUEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.ComboBox ma_PhongComboBox;
    }
}