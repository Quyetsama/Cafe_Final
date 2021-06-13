
namespace QuanLyQuanCafe_Nhom14
{
    partial class f_DanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_DanhMuc));
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgDanhSachLSP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTKDanhMuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemSua = new Guna.UI2.WinForms.Guna2Button();
            this.cbbTrangThaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Controls.Add(this.dtgDanhSachLSP);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(2, 150);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(1400, 570);
            this.guna2GroupBox3.TabIndex = 34;
            this.guna2GroupBox3.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // dtgDanhSachLSP
            // 
            this.dtgDanhSachLSP.AllowUserToAddRows = false;
            this.dtgDanhSachLSP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgDanhSachLSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDanhSachLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDanhSachLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDanhSachLSP.BackgroundColor = System.Drawing.Color.White;
            this.dtgDanhSachLSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDanhSachLSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgDanhSachLSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDanhSachLSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgDanhSachLSP.ColumnHeadersHeight = 35;
            this.dtgDanhSachLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDanhSachLSP.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgDanhSachLSP.EnableHeadersVisualStyles = false;
            this.dtgDanhSachLSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgDanhSachLSP.Location = new System.Drawing.Point(3, 40);
            this.dtgDanhSachLSP.Name = "dtgDanhSachLSP";
            this.dtgDanhSachLSP.ReadOnly = true;
            this.dtgDanhSachLSP.RowHeadersVisible = false;
            this.dtgDanhSachLSP.RowTemplate.Height = 35;
            this.dtgDanhSachLSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDanhSachLSP.Size = new System.Drawing.Size(1394, 527);
            this.dtgDanhSachLSP.TabIndex = 4;
            this.dtgDanhSachLSP.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgDanhSachLSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgDanhSachLSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgDanhSachLSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgDanhSachLSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgDanhSachLSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgDanhSachLSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgDanhSachLSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgDanhSachLSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgDanhSachLSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgDanhSachLSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgDanhSachLSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgDanhSachLSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgDanhSachLSP.ThemeStyle.HeaderStyle.Height = 35;
            this.dtgDanhSachLSP.ThemeStyle.ReadOnly = true;
            this.dtgDanhSachLSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgDanhSachLSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgDanhSachLSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgDanhSachLSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgDanhSachLSP.ThemeStyle.RowsStyle.Height = 35;
            this.dtgDanhSachLSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgDanhSachLSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDanhSachLSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachLSP_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên Danh Mục";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Trạng Thái";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // cbbTKDanhMuc
            // 
            this.cbbTKDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.cbbTKDanhMuc.BorderRadius = 12;
            this.cbbTKDanhMuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTKDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTKDanhMuc.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTKDanhMuc.FocusedState.Parent = this.cbbTKDanhMuc;
            this.cbbTKDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTKDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTKDanhMuc.FormattingEnabled = true;
            this.cbbTKDanhMuc.HoverState.Parent = this.cbbTKDanhMuc;
            this.cbbTKDanhMuc.ItemHeight = 30;
            this.cbbTKDanhMuc.ItemsAppearance.Parent = this.cbbTKDanhMuc;
            this.cbbTKDanhMuc.Location = new System.Drawing.Point(1030, 23);
            this.cbbTKDanhMuc.Name = "cbbTKDanhMuc";
            this.cbbTKDanhMuc.ShadowDecoration.Parent = this.cbbTKDanhMuc;
            this.cbbTKDanhMuc.Size = new System.Drawing.Size(245, 36);
            this.cbbTKDanhMuc.TabIndex = 43;
            this.cbbTKDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbbTKDanhMuc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(946, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.CheckedState.Parent = this.btnExportExcel;
            this.btnExportExcel.HoverState.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnExportExcel.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExportExcel.HoverState.Parent = this.btnExportExcel;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnExportExcel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExportExcel.Location = new System.Drawing.Point(454, 96);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.PressedState.Parent = this.btnExportExcel;
            this.btnExportExcel.Size = new System.Drawing.Size(99, 36);
            this.btnExportExcel.TabIndex = 41;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 12;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(310, 96);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(99, 36);
            this.btnLamMoi.TabIndex = 40;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThemSua
            // 
            this.btnThemSua.BorderRadius = 12;
            this.btnThemSua.CheckedState.Parent = this.btnThemSua;
            this.btnThemSua.CustomImages.Parent = this.btnThemSua;
            this.btnThemSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSua.ForeColor = System.Drawing.Color.White;
            this.btnThemSua.HoverState.Parent = this.btnThemSua;
            this.btnThemSua.Location = new System.Drawing.Point(163, 96);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.ShadowDecoration.Parent = this.btnThemSua;
            this.btnThemSua.Size = new System.Drawing.Size(99, 36);
            this.btnThemSua.TabIndex = 39;
            this.btnThemSua.Text = "Thêm";
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // cbbTrangThaiSP
            // 
            this.cbbTrangThaiSP.BackColor = System.Drawing.Color.Transparent;
            this.cbbTrangThaiSP.BorderRadius = 12;
            this.cbbTrangThaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTrangThaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThaiSP.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTrangThaiSP.FocusedState.Parent = this.cbbTrangThaiSP;
            this.cbbTrangThaiSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTrangThaiSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTrangThaiSP.FormattingEnabled = true;
            this.cbbTrangThaiSP.HoverState.Parent = this.cbbTrangThaiSP;
            this.cbbTrangThaiSP.ItemHeight = 30;
            this.cbbTrangThaiSP.ItemsAppearance.Parent = this.cbbTrangThaiSP;
            this.cbbTrangThaiSP.Location = new System.Drawing.Point(611, 23);
            this.cbbTrangThaiSP.Name = "cbbTrangThaiSP";
            this.cbbTrangThaiSP.ShadowDecoration.Parent = this.cbbTrangThaiSP;
            this.cbbTrangThaiSP.Size = new System.Drawing.Size(245, 36);
            this.cbbTrangThaiSP.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Trạng Thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên Sản Phẩm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderRadius = 12;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.Parent = this.txtTenSP;
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.FocusedState.Parent = this.txtTenSP;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.HoverState.Parent = this.txtTenSP;
            this.txtTenSP.Location = new System.Drawing.Point(163, 23);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.ShadowDecoration.Parent = this.txtTenSP;
            this.txtTenSP.Size = new System.Drawing.Size(246, 36);
            this.txtTenSP.TabIndex = 36;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.ImageOffset = new System.Drawing.Point(0, -1);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.Location = new System.Drawing.Point(1352, 2);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(50, 36);
            this.guna2ImageButton2.TabIndex = 44;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // f_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 722);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.cbbTKDanhMuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.cbbTrangThaiSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_DanhMuc";
            this.Text = "f_DanhMuc";
            this.Load += new System.EventHandler(this.f_DanhMuc_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2DataGridView dtgDanhSachLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTKDanhMuc;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnExportExcel;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnThemSua;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThaiSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
    }
}