namespace Homestay_Management_System
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_TenDangNhap = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.linklb_DangKy = new System.Windows.Forms.LinkLabel();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.ckbox_HienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_Welcome.Location = new System.Drawing.Point(170, 9);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Welcome.Size = new System.Drawing.Size(182, 23);
            this.lb_Welcome.TabIndex = 0;
            this.lb_Welcome.Text = "CHÀO MỪNG";
            this.lb_Welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lb_TenDangNhap
            // 
            this.lb_TenDangNhap.AutoSize = true;
            this.lb_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(69)))), ((int)(((byte)(190)))));
            this.lb_TenDangNhap.Location = new System.Drawing.Point(91, 58);
            this.lb_TenDangNhap.Name = "lb_TenDangNhap";
            this.lb_TenDangNhap.Size = new System.Drawing.Size(116, 20);
            this.lb_TenDangNhap.TabIndex = 2;
            this.lb_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(69)))), ((int)(((byte)(190)))));
            this.lb_MatKhau.Location = new System.Drawing.Point(132, 117);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(75, 20);
            this.lb_MatKhau.TabIndex = 3;
            this.lb_MatKhau.Text = "Mật khẩu";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap.Location = new System.Drawing.Point(263, 56);
            this.txt_TenDangNhap.MaxLength = 100;
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(165, 26);
            this.txt_TenDangNhap.TabIndex = 4;
            this.txt_TenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenDangNhap_KeyPress);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(263, 111);
            this.txt_MatKhau.MaxLength = 100;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(165, 26);
            this.txt_MatKhau.TabIndex = 5;
            this.txt_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MatKhau_KeyPress);
            // 
            // linklb_DangKy
            // 
            this.linklb_DangKy.AutoSize = true;
            this.linklb_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_DangKy.Location = new System.Drawing.Point(468, 260);
            this.linklb_DangKy.Name = "linklb_DangKy";
            this.linklb_DangKy.Size = new System.Drawing.Size(52, 16);
            this.linklb_DangKy.TabIndex = 7;
            this.linklb_DangKy.TabStop = true;
            this.linklb_DangKy.Text = "Đăng kí";
            this.linklb_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_DangKy_LinkClicked);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(220)))), ((int)(((byte)(69)))));
            this.btn_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangNhap.Location = new System.Drawing.Point(205, 194);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(118, 38);
            this.btn_DangNhap.TabIndex = 8;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // ckbox_HienThiMatKhau
            // 
            this.ckbox_HienThiMatKhau.AutoSize = true;
            this.ckbox_HienThiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.ckbox_HienThiMatKhau.Location = new System.Drawing.Point(263, 144);
            this.ckbox_HienThiMatKhau.Name = "ckbox_HienThiMatKhau";
            this.ckbox_HienThiMatKhau.Size = new System.Drawing.Size(109, 17);
            this.ckbox_HienThiMatKhau.TabIndex = 9;
            this.ckbox_HienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.ckbox_HienThiMatKhau.UseVisualStyleBackColor = true;
            this.ckbox_HienThiMatKhau.CheckedChanged += new System.EventHandler(this.ckbox_HienThiMatKhau_CheckedChanged);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.Location = new System.Drawing.Point(510, -6);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(35, 38);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(542, 282);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.ckbox_HienThiMatKhau);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.linklb_DangKy);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.lb_MatKhau);
            this.Controls.Add(this.lb_TenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Welcome);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(59)))), ((int)(((byte)(37)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_TenDangNhap;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.LinkLabel linklb_DangKy;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.CheckBox ckbox_HienThiMatKhau;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button button2;
    }
}

