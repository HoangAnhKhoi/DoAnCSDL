namespace giaodien
{
    partial class Form_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabThuNgan = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_chucvu = new System.Windows.Forms.ComboBox();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rdn_nu = new System.Windows.Forms.RadioButton();
            this.rbn_nam = new System.Windows.Forms.RadioButton();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cccdnv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sdtnv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dchinv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.btn_suanv = new Guna.UI.WinForms.GunaButton();
            this.btn_xoanv = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_themnv = new Guna.UI.WinForms.GunaButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.data_nv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabThuNgan.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabThuNgan
            // 
            this.tabThuNgan.Controls.Add(this.tabPage1);
            this.tabThuNgan.Controls.Add(this.tabPage2);
            this.tabThuNgan.Location = new System.Drawing.Point(3, 0);
            this.tabThuNgan.Name = "tabThuNgan";
            this.tabThuNgan.SelectedIndex = 0;
            this.tabThuNgan.Size = new System.Drawing.Size(786, 484);
            this.tabThuNgan.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.data_nv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thu ngân";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cb_chucvu);
            this.groupBox1.Controls.Add(this.date_ngaysinh);
            this.groupBox1.Controls.Add(this.rdn_nu);
            this.groupBox1.Controls.Add(this.rbn_nam);
            this.groupBox1.Controls.Add(this.txt_luong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_cccdnv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_sdtnv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_dchinv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.btn_suanv);
            this.groupBox1.Controls.Add(this.btn_xoanv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_themnv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(426, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 448);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cb_chucvu
            // 
            this.cb_chucvu.FormattingEnabled = true;
            this.cb_chucvu.Location = new System.Drawing.Point(107, 282);
            this.cb_chucvu.Margin = new System.Windows.Forms.Padding(2);
            this.cb_chucvu.Name = "cb_chucvu";
            this.cb_chucvu.Size = new System.Drawing.Size(222, 21);
            this.cb_chucvu.TabIndex = 66;
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaysinh.Location = new System.Drawing.Point(107, 103);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(221, 22);
            this.date_ngaysinh.TabIndex = 65;
            // 
            // rdn_nu
            // 
            this.rdn_nu.AutoSize = true;
            this.rdn_nu.Checked = true;
            this.rdn_nu.Location = new System.Drawing.Point(226, 142);
            this.rdn_nu.Name = "rdn_nu";
            this.rdn_nu.Size = new System.Drawing.Size(39, 17);
            this.rdn_nu.TabIndex = 64;
            this.rdn_nu.TabStop = true;
            this.rdn_nu.Text = "Nữ";
            this.rdn_nu.UseVisualStyleBackColor = true;
            // 
            // rbn_nam
            // 
            this.rbn_nam.AutoSize = true;
            this.rbn_nam.Location = new System.Drawing.Point(119, 142);
            this.rbn_nam.Name = "rbn_nam";
            this.rbn_nam.Size = new System.Drawing.Size(47, 17);
            this.rbn_nam.TabIndex = 63;
            this.rbn_nam.Text = "Nam";
            this.rbn_nam.UseVisualStyleBackColor = true;
            // 
            // txt_luong
            // 
            this.txt_luong.Location = new System.Drawing.Point(108, 315);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(221, 20);
            this.txt_luong.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Lương:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Mã chức vụ";
            // 
            // txt_cccdnv
            // 
            this.txt_cccdnv.Location = new System.Drawing.Point(108, 249);
            this.txt_cccdnv.Name = "txt_cccdnv";
            this.txt_cccdnv.Size = new System.Drawing.Size(221, 20);
            this.txt_cccdnv.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Số CCCD:";
            // 
            // txt_sdtnv
            // 
            this.txt_sdtnv.Location = new System.Drawing.Point(108, 212);
            this.txt_sdtnv.Name = "txt_sdtnv";
            this.txt_sdtnv.Size = new System.Drawing.Size(221, 20);
            this.txt_sdtnv.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Số điện thoại:";
            // 
            // txt_dchinv
            // 
            this.txt_dchinv.Location = new System.Drawing.Point(108, 175);
            this.txt_dchinv.Name = "txt_dchinv";
            this.txt_dchinv.Size = new System.Drawing.Size(221, 20);
            this.txt_dchinv.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Địa chỉ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ngày sinh:";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(107, 67);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(221, 20);
            this.txt_tennv.TabIndex = 48;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(107, 25);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(221, 20);
            this.txt_manv.TabIndex = 46;
            // 
            // btn_suanv
            // 
            this.btn_suanv.AnimationHoverSpeed = 0.07F;
            this.btn_suanv.AnimationSpeed = 0.03F;
            this.btn_suanv.BackColor = System.Drawing.Color.Transparent;
            this.btn_suanv.BaseColor = System.Drawing.Color.Transparent;
            this.btn_suanv.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suanv.BorderSize = 2;
            this.btn_suanv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_suanv.FocusedColor = System.Drawing.Color.Empty;
            this.btn_suanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suanv.ForeColor = System.Drawing.Color.Black;
            this.btn_suanv.Image = null;
            this.btn_suanv.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_suanv.Location = new System.Drawing.Point(119, 400);
            this.btn_suanv.Name = "btn_suanv";
            this.btn_suanv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_suanv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_suanv.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_suanv.OnHoverImage = null;
            this.btn_suanv.OnPressedColor = System.Drawing.Color.Black;
            this.btn_suanv.Radius = 20;
            this.btn_suanv.Size = new System.Drawing.Size(102, 46);
            this.btn_suanv.TabIndex = 20;
            this.btn_suanv.Text = "Sửa ";
            this.btn_suanv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_xoanv
            // 
            this.btn_xoanv.AnimationHoverSpeed = 0.07F;
            this.btn_xoanv.AnimationSpeed = 0.03F;
            this.btn_xoanv.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoanv.BaseColor = System.Drawing.Color.Transparent;
            this.btn_xoanv.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoanv.BorderSize = 2;
            this.btn_xoanv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoanv.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoanv.ForeColor = System.Drawing.Color.Black;
            this.btn_xoanv.Image = null;
            this.btn_xoanv.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_xoanv.Location = new System.Drawing.Point(226, 400);
            this.btn_xoanv.Name = "btn_xoanv";
            this.btn_xoanv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xoanv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoanv.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoanv.OnHoverImage = null;
            this.btn_xoanv.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoanv.Radius = 20;
            this.btn_xoanv.Size = new System.Drawing.Size(102, 46);
            this.btn_xoanv.TabIndex = 17;
            this.btn_xoanv.Text = "Xoá ";
            this.btn_xoanv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tên nhân viên:";
            // 
            // btn_themnv
            // 
            this.btn_themnv.AnimationHoverSpeed = 0.07F;
            this.btn_themnv.AnimationSpeed = 0.03F;
            this.btn_themnv.BackColor = System.Drawing.Color.Transparent;
            this.btn_themnv.BaseColor = System.Drawing.Color.Transparent;
            this.btn_themnv.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themnv.BorderSize = 2;
            this.btn_themnv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_themnv.FocusedColor = System.Drawing.Color.Empty;
            this.btn_themnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themnv.ForeColor = System.Drawing.Color.Black;
            this.btn_themnv.Image = null;
            this.btn_themnv.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_themnv.Location = new System.Drawing.Point(11, 400);
            this.btn_themnv.Name = "btn_themnv";
            this.btn_themnv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_themnv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_themnv.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_themnv.OnHoverImage = null;
            this.btn_themnv.OnPressedColor = System.Drawing.Color.Black;
            this.btn_themnv.Radius = 20;
            this.btn_themnv.Size = new System.Drawing.Size(102, 46);
            this.btn_themnv.TabIndex = 18;
            this.btn_themnv.Text = "Thêm";
            this.btn_themnv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(13, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺" +
    "⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Mã nhân viên:";
            // 
            // data_nv
            // 
            this.data_nv.AllowUserToAddRows = false;
            this.data_nv.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.data_nv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_nv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_nv.ColumnHeadersHeight = 40;
            this.data_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column8,
            this.Column9});
            this.data_nv.Location = new System.Drawing.Point(0, 0);
            this.data_nv.Name = "data_nv";
            this.data_nv.RowHeadersVisible = false;
            this.data_nv.RowHeadersWidth = 50;
            this.data_nv.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.data_nv.Size = new System.Drawing.Size(420, 458);
            this.data_nv.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "NV_NguoiID";
            this.Column1.FillWeight = 228.4264F;
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 97;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.DataPropertyName = "Hoten";
            this.Column2.FillWeight = 83.94669F;
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.FillWeight = 83.94669F;
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "DienThoai";
            this.Column4.FillWeight = 83.94669F;
            this.Column4.HeaderText = "Điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 81;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.DataPropertyName = "NgaySinh";
            this.Column5.FillWeight = 83.94669F;
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 79;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.DataPropertyName = "CCCD";
            this.Column7.FillWeight = 83.94669F;
            this.Column7.HeaderText = "CCCD";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 65;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GioiTinh";
            this.Column6.FillWeight = 83.94669F;
            this.Column6.HeaderText = "Giới tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenCV";
            this.Column8.FillWeight = 83.94669F;
            this.Column8.HeaderText = "Mã chức vụ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column9.DataPropertyName = "Luong";
            this.Column9.FillWeight = 83.94669F;
            this.Column9.HeaderText = "Lương";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 67;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(778, 462);
            this.dataGridView1.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NV_NguoiID";
            this.dataGridViewTextBoxColumn1.FillWeight = 228.4264F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hoten";
            this.dataGridViewTextBoxColumn2.FillWeight = 83.94669F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhân viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn3.FillWeight = 83.94669F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DienThoai";
            this.dataGridViewTextBoxColumn4.FillWeight = 83.94669F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Điện thoại";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn5.FillWeight = 83.94669F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CCCD";
            this.dataGridViewTextBoxColumn6.FillWeight = 83.94669F;
            this.dataGridViewTextBoxColumn6.HeaderText = "CCCD";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn7.FillWeight = 83.94669F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TenCV";
            this.dataGridViewTextBoxColumn8.FillWeight = 83.94669F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã chức vụ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Luong";
            this.dataGridViewTextBoxColumn9.FillWeight = 83.94669F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Lương";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.tabThuNgan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_NhanVien";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_NhanVien_Load);
            this.tabThuNgan.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabThuNgan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_chucvu;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.RadioButton rdn_nu;
        private System.Windows.Forms.RadioButton rbn_nam;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cccdnv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sdtnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dchinv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_manv;
        private Guna.UI.WinForms.GunaButton btn_suanv;
        private Guna.UI.WinForms.GunaButton btn_xoanv;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btn_themnv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView data_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}