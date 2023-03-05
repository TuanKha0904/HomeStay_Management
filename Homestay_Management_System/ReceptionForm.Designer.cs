namespace Homestay_Management_System
{
    partial class frm_ReceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReceptionForm));
            this.Menu_Bar = new System.Windows.Forms.ToolStrip();
            this.btn_XemPhong = new System.Windows.Forms.ToolStripButton();
            this.btn_XemDichVu = new System.Windows.Forms.ToolStripButton();
            this.btn_KhachDatPhong = new System.Windows.Forms.ToolStripButton();
            this.btn_DangXuat = new System.Windows.Forms.ToolStripButton();
            this.btn_HoSo = new System.Windows.Forms.ToolStripButton();
            this.btn_KhachDungDichVu = new System.Windows.Forms.ToolStripButton();
            this.btn_HoaDon = new System.Windows.Forms.ToolStripButton();
            this.btn_ChiTietHoaDon = new System.Windows.Forms.ToolStripButton();
            this.btn_KhachHang = new System.Windows.Forms.ToolStripButton();
            this.pnl_Forms = new System.Windows.Forms.Panel();
            this.Menu_Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Bar
            // 
            this.Menu_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.Menu_Bar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_Bar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_XemPhong,
            this.btn_XemDichVu,
            this.btn_KhachDatPhong,
            this.btn_DangXuat,
            this.btn_HoSo,
            this.btn_KhachDungDichVu,
            this.btn_HoaDon,
            this.btn_ChiTietHoaDon,
            this.btn_KhachHang});
            this.Menu_Bar.Location = new System.Drawing.Point(0, 0);
            this.Menu_Bar.Name = "Menu_Bar";
            this.Menu_Bar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu_Bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu_Bar.Size = new System.Drawing.Size(1054, 46);
            this.Menu_Bar.Stretch = true;
            this.Menu_Bar.TabIndex = 3;
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
            // btn_KhachDatPhong
            // 
            this.btn_KhachDatPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachDatPhong.ForeColor = System.Drawing.Color.White;
            this.btn_KhachDatPhong.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachDatPhong.Image")));
            this.btn_KhachDatPhong.ImageTransparentColor = System.Drawing.Color.Red;
            this.btn_KhachDatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_KhachDatPhong.Name = "btn_KhachDatPhong";
            this.btn_KhachDatPhong.Padding = new System.Windows.Forms.Padding(5);
            this.btn_KhachDatPhong.Size = new System.Drawing.Size(147, 46);
            this.btn_KhachDatPhong.Text = "Khách đặt phòng";
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
            // btn_KhachDungDichVu
            // 
            this.btn_KhachDungDichVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachDungDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_KhachDungDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachDungDichVu.Image")));
            this.btn_KhachDungDichVu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_KhachDungDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_KhachDungDichVu.Name = "btn_KhachDungDichVu";
            this.btn_KhachDungDichVu.Size = new System.Drawing.Size(151, 46);
            this.btn_KhachDungDichVu.Text = "Khách dùng dịch vụ";
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.Image")));
            this.btn_HoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_HoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(91, 46);
            this.btn_HoaDon.Text = "Hóa đơn";
            // 
            // btn_ChiTietHoaDon
            // 
            this.btn_ChiTietHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTietHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_ChiTietHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChiTietHoaDon.Image")));
            this.btn_ChiTietHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ChiTietHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChiTietHoaDon.Name = "btn_ChiTietHoaDon";
            this.btn_ChiTietHoaDon.Size = new System.Drawing.Size(132, 46);
            this.btn_ChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_KhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.Image")));
            this.btn_KhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_KhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(147, 36);
            this.btn_KhachHang.Text = "Quản lí khách hàng";
            // 
            // pnl_Forms
            // 
            this.pnl_Forms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_Forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Forms.Location = new System.Drawing.Point(0, 46);
            this.pnl_Forms.Name = "pnl_Forms";
            this.pnl_Forms.Size = new System.Drawing.Size(1054, 404);
            this.pnl_Forms.TabIndex = 4;
            // 
            // frm_ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.pnl_Forms);
            this.Controls.Add(this.Menu_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ReceptionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ReceptionForm_Load);
            this.Menu_Bar.ResumeLayout(false);
            this.Menu_Bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_Bar;
        private System.Windows.Forms.ToolStripButton btn_XemPhong;
        private System.Windows.Forms.ToolStripButton btn_XemDichVu;
        private System.Windows.Forms.ToolStripButton btn_KhachDatPhong;
        private System.Windows.Forms.ToolStripButton btn_DangXuat;
        private System.Windows.Forms.ToolStripButton btn_HoSo;
        private System.Windows.Forms.ToolStripButton btn_KhachDungDichVu;
        private System.Windows.Forms.ToolStripButton btn_HoaDon;
        private System.Windows.Forms.ToolStripButton btn_ChiTietHoaDon;
        private System.Windows.Forms.ToolStripButton btn_KhachHang;
        private System.Windows.Forms.Panel pnl_Forms;
    }
}