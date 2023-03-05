namespace Homestay_Management_System
{
    partial class frm_HoSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoSo));
            this.ptb_Image = new System.Windows.Forms.PictureBox();
            this.hOMESTAY_MANAGEMENTDataSet = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSet();
            this.tAI_KHOAN_APPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAI_KHOAN_APPTableAdapter = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TAI_KHOAN_APPTableAdapter();
            this.tableAdapterManager = new Homestay_Management_System.HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager();
            this.btn_Chinhsua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_DoiMatKhau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.txt_GioiTinh = new System.Windows.Forms.TextBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.lb_mkmoi = new System.Windows.Forms.Label();
            this.txt_MKMoi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_LuuMK = new System.Windows.Forms.Button();
            this.lb_NhapLaiMK = new System.Windows.Forms.Label();
            this.txt_NhapLaiMK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAI_KHOAN_APPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_Image
            // 
            this.ptb_Image.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptb_Image.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Image.Image")));
            this.ptb_Image.Location = new System.Drawing.Point(0, 0);
            this.ptb_Image.Name = "ptb_Image";
            this.ptb_Image.Size = new System.Drawing.Size(800, 72);
            this.ptb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptb_Image.TabIndex = 0;
            this.ptb_Image.TabStop = false;
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
            // btn_Chinhsua
            // 
            this.btn_Chinhsua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Chinhsua.BackColor = System.Drawing.Color.Yellow;
            this.btn_Chinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chinhsua.Location = new System.Drawing.Point(101, 388);
            this.btn_Chinhsua.Name = "btn_Chinhsua";
            this.btn_Chinhsua.Size = new System.Drawing.Size(200, 50);
            this.btn_Chinhsua.TabIndex = 11;
            this.btn_Chinhsua.Text = "Chỉnh sửa thông tin";
            this.btn_Chinhsua.UseVisualStyleBackColor = false;
            this.btn_Chinhsua.Click += new System.EventHandler(this.btn_Chinhsua_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Luu.BackColor = System.Drawing.Color.Yellow;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(345, 388);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(200, 50);
            this.btn_Luu.TabIndex = 12;
            this.btn_Luu.Text = "Lưu thông tin";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DoiMatKhau.BackColor = System.Drawing.Color.Yellow;
            this.btn_DoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(572, 388);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(200, 50);
            this.btn_DoiMatKhau.TabIndex = 13;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu";
            this.btn_DoiMatKhau.UseVisualStyleBackColor = false;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Tài Khoản:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới Tính:";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TenTK.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_TenTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TenTK.Enabled = false;
            this.txt_TenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTK.Location = new System.Drawing.Point(445, 101);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(100, 19);
            this.txt_TenTK.TabIndex = 6;
            this.txt_TenTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MatKhau.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MatKhau.Enabled = false;
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(445, 163);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(100, 19);
            this.txt_MatKhau.TabIndex = 7;
            this.txt_MatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_HoTen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_HoTen.Enabled = false;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(445, 216);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(100, 19);
            this.txt_HoTen.TabIndex = 8;
            this.txt_HoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NgaySinh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NgaySinh.Enabled = false;
            this.txt_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgaySinh.Location = new System.Drawing.Point(445, 271);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(100, 19);
            this.txt_NgaySinh.TabIndex = 9;
            this.txt_NgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GioiTinh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_GioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_GioiTinh.Enabled = false;
            this.txt_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioiTinh.Location = new System.Drawing.Point(445, 335);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(100, 19);
            this.txt_GioiTinh.TabIndex = 10;
            this.txt_GioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(445, 271);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(100, 26);
            this.dtp_NgaySinh.TabIndex = 14;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_GioiTinh.Location = new System.Drawing.Point(445, 335);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(100, 28);
            this.cbb_GioiTinh.TabIndex = 15;
            this.cbb_GioiTinh.Text = "Nam";
            // 
            // lb_mkmoi
            // 
            this.lb_mkmoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mkmoi.AutoSize = true;
            this.lb_mkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mkmoi.Location = new System.Drawing.Point(277, 222);
            this.lb_mkmoi.Name = "lb_mkmoi";
            this.lb_mkmoi.Size = new System.Drawing.Size(121, 20);
            this.lb_mkmoi.TabIndex = 16;
            this.lb_mkmoi.Text = "Mật khẩu mới:";
            // 
            // txt_MKMoi
            // 
            this.txt_MKMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MKMoi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_MKMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MKMoi.Enabled = false;
            this.txt_MKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MKMoi.Location = new System.Drawing.Point(445, 216);
            this.txt_MKMoi.Name = "txt_MKMoi";
            this.txt_MKMoi.Size = new System.Drawing.Size(100, 19);
            this.txt_MKMoi.TabIndex = 17;
            this.txt_MKMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MKMoi.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(551, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_LuuMK
            // 
            this.btn_LuuMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LuuMK.BackColor = System.Drawing.Color.Magenta;
            this.btn_LuuMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuMK.Location = new System.Drawing.Point(551, 205);
            this.btn_LuuMK.Name = "btn_LuuMK";
            this.btn_LuuMK.Size = new System.Drawing.Size(108, 30);
            this.btn_LuuMK.TabIndex = 19;
            this.btn_LuuMK.Text = "Lưu Mật Khẩu";
            this.btn_LuuMK.UseVisualStyleBackColor = false;
            this.btn_LuuMK.Click += new System.EventHandler(this.btn_LuuMK_Click);
            // 
            // lb_NhapLaiMK
            // 
            this.lb_NhapLaiMK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NhapLaiMK.AutoSize = true;
            this.lb_NhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhapLaiMK.Location = new System.Drawing.Point(240, 277);
            this.lb_NhapLaiMK.Name = "lb_NhapLaiMK";
            this.lb_NhapLaiMK.Size = new System.Drawing.Size(158, 20);
            this.lb_NhapLaiMK.TabIndex = 20;
            this.lb_NhapLaiMK.Text = "Nhập lại mật khẩu:";
            // 
            // txt_NhapLaiMK
            // 
            this.txt_NhapLaiMK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NhapLaiMK.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NhapLaiMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NhapLaiMK.Enabled = false;
            this.txt_NhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhapLaiMK.Location = new System.Drawing.Point(445, 276);
            this.txt_NhapLaiMK.Name = "txt_NhapLaiMK";
            this.txt_NhapLaiMK.Size = new System.Drawing.Size(100, 19);
            this.txt_NhapLaiMK.TabIndex = 21;
            this.txt_NhapLaiMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NhapLaiMK.UseSystemPasswordChar = true;
            // 
            // frm_HoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_NhapLaiMK);
            this.Controls.Add(this.lb_NhapLaiMK);
            this.Controls.Add(this.btn_LuuMK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_MKMoi);
            this.Controls.Add(this.lb_mkmoi);
            this.Controls.Add(this.cbb_GioiTinh);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.btn_DoiMatKhau);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Chinhsua);
            this.Controls.Add(this.txt_GioiTinh);
            this.Controls.Add(this.txt_NgaySinh);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HoSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HoSo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_HoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMESTAY_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAI_KHOAN_APPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Image;
        private HOMESTAY_MANAGEMENTDataSet hOMESTAY_MANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource tAI_KHOAN_APPBindingSource;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.TAI_KHOAN_APPTableAdapter tAI_KHOAN_APPTableAdapter;
        private HOMESTAY_MANAGEMENTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_Chinhsua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_DoiMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.TextBox txt_GioiTinh;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.Label lb_mkmoi;
        private System.Windows.Forms.TextBox txt_MKMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_LuuMK;
        private System.Windows.Forms.Label lb_NhapLaiMK;
        private System.Windows.Forms.TextBox txt_NhapLaiMK;
    }
}