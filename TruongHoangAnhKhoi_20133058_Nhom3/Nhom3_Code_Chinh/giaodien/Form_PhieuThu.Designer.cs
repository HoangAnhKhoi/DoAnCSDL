namespace giaodien
{
    partial class Form_PhieuThu
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
            this.data_phieuthu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_timpt = new Guna.UI.WinForms.GunaButton();
            this.btn_xuatpt = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txt_tienthu = new Guna.UI.WinForms.GunaTextBox();
            this.txt_mahd = new Guna.UI.WinForms.GunaTextBox();
            this.txt_sopt = new Guna.UI.WinForms.GunaTextBox();
            this.txt_hoten = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_taopt = new Guna.UI.WinForms.GunaButton();
            this.txt_tienthieu = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_phieuthu)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_phieuthu
            // 
            this.data_phieuthu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_phieuthu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_phieuthu.ColumnHeadersHeight = 46;
            this.data_phieuthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.data_phieuthu.Location = new System.Drawing.Point(12, 229);
            this.data_phieuthu.Name = "data_phieuthu";
            this.data_phieuthu.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_phieuthu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_phieuthu.RowHeadersVisible = false;
            this.data_phieuthu.RowHeadersWidth = 30;
            this.data_phieuthu.Size = new System.Drawing.Size(768, 211);
            this.data_phieuthu.TabIndex = 3;
            this.data_phieuthu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_phieuthu_CellClick);
            this.data_phieuthu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_phieuthu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Số phiếu thu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "Mã hợp đồng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 70F;
            this.Column3.HeaderText = "Mã khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 134.4052F;
            this.Column4.HeaderText = "Họ Tên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 134.4052F;
            this.Column5.HeaderText = "Số tiền thu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 120F;
            this.Column6.HeaderText = "Ngày lập phiếu thu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_timpt
            // 
            this.btn_timpt.AnimationHoverSpeed = 0.07F;
            this.btn_timpt.AnimationSpeed = 0.03F;
            this.btn_timpt.BackColor = System.Drawing.Color.Transparent;
            this.btn_timpt.BaseColor = System.Drawing.Color.Transparent;
            this.btn_timpt.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_timpt.BorderSize = 2;
            this.btn_timpt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_timpt.FocusedColor = System.Drawing.Color.Empty;
            this.btn_timpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timpt.ForeColor = System.Drawing.Color.LightGray;
            this.btn_timpt.Image = null;
            this.btn_timpt.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_timpt.Location = new System.Drawing.Point(591, 34);
            this.btn_timpt.Name = "btn_timpt";
            this.btn_timpt.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_timpt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_timpt.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_timpt.OnHoverImage = null;
            this.btn_timpt.OnPressedColor = System.Drawing.Color.Black;
            this.btn_timpt.Radius = 20;
            this.btn_timpt.Size = new System.Drawing.Size(130, 59);
            this.btn_timpt.TabIndex = 14;
            this.btn_timpt.Text = "Tìm hợp đồng";
            this.btn_timpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_timpt.Click += new System.EventHandler(this.btn_timpt_Click);
            // 
            // btn_xuatpt
            // 
            this.btn_xuatpt.AnimationHoverSpeed = 0.07F;
            this.btn_xuatpt.AnimationSpeed = 0.03F;
            this.btn_xuatpt.BackColor = System.Drawing.Color.Transparent;
            this.btn_xuatpt.BaseColor = System.Drawing.Color.Transparent;
            this.btn_xuatpt.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xuatpt.BorderSize = 2;
            this.btn_xuatpt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xuatpt.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xuatpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatpt.ForeColor = System.Drawing.Color.LightGray;
            this.btn_xuatpt.Image = null;
            this.btn_xuatpt.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_xuatpt.Location = new System.Drawing.Point(664, 118);
            this.btn_xuatpt.Name = "btn_xuatpt";
            this.btn_xuatpt.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xuatpt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xuatpt.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xuatpt.OnHoverImage = null;
            this.btn_xuatpt.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xuatpt.Radius = 20;
            this.btn_xuatpt.Size = new System.Drawing.Size(122, 59);
            this.btn_xuatpt.TabIndex = 16;
            this.btn_xuatpt.Text = "Xuất phiếu thu";
            this.btn_xuatpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xuatpt.Click += new System.EventHandler(this.btn_xuatpt_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.txt_tienthu);
            this.gunaGroupBox1.Controls.Add(this.txt_mahd);
            this.gunaGroupBox1.Controls.Add(this.txt_sopt);
            this.gunaGroupBox1.Controls.Add(this.txt_hoten);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(504, 211);
            this.gunaGroupBox1.TabIndex = 17;
            this.gunaGroupBox1.Text = "Thông tin phiếu thu";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(170, 4);
            // 
            // txt_tienthu
            // 
            this.txt_tienthu.BaseColor = System.Drawing.Color.White;
            this.txt_tienthu.BorderColor = System.Drawing.Color.Silver;
            this.txt_tienthu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tienthu.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tienthu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tienthu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tienthu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tienthu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_tienthu.Location = new System.Drawing.Point(263, 156);
            this.txt_tienthu.Name = "txt_tienthu";
            this.txt_tienthu.PasswordChar = '\0';
            this.txt_tienthu.SelectedText = "";
            this.txt_tienthu.Size = new System.Drawing.Size(217, 30);
            this.txt_tienthu.TabIndex = 23;
            this.txt_tienthu.Leave += new System.EventHandler(this.txt_tienthu_Leave);
            // 
            // txt_mahd
            // 
            this.txt_mahd.BaseColor = System.Drawing.Color.White;
            this.txt_mahd.BorderColor = System.Drawing.Color.Silver;
            this.txt_mahd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mahd.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_mahd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_mahd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mahd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mahd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_mahd.Location = new System.Drawing.Point(263, 75);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.PasswordChar = '\0';
            this.txt_mahd.SelectedText = "";
            this.txt_mahd.Size = new System.Drawing.Size(217, 30);
            this.txt_mahd.TabIndex = 22;
            this.txt_mahd.Leave += new System.EventHandler(this.txt_mahd_Leave);
            // 
            // txt_sopt
            // 
            this.txt_sopt.BaseColor = System.Drawing.Color.White;
            this.txt_sopt.BorderColor = System.Drawing.Color.Silver;
            this.txt_sopt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sopt.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_sopt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_sopt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_sopt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sopt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_sopt.Location = new System.Drawing.Point(12, 74);
            this.txt_sopt.Name = "txt_sopt";
            this.txt_sopt.PasswordChar = '\0';
            this.txt_sopt.SelectedText = "";
            this.txt_sopt.Size = new System.Drawing.Size(217, 30);
            this.txt_sopt.TabIndex = 21;
            this.txt_sopt.TextChanged += new System.EventHandler(this.txt_sopt_TextChanged);
            this.txt_sopt.Enter += new System.EventHandler(this.txt_sopt_Enter);
            this.txt_sopt.Leave += new System.EventHandler(this.txt_sopt_Leave);
            // 
            // txt_hoten
            // 
            this.txt_hoten.BaseColor = System.Drawing.Color.White;
            this.txt_hoten.BorderColor = System.Drawing.Color.Silver;
            this.txt_hoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hoten.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_hoten.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_hoten.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_hoten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_hoten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_hoten.Location = new System.Drawing.Point(12, 156);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.PasswordChar = '\0';
            this.txt_hoten.SelectedText = "";
            this.txt_hoten.Size = new System.Drawing.Size(217, 30);
            this.txt_hoten.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số phiếu thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(260, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã hợp đồng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(260, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số tiền thu";
            // 
            // btn_taopt
            // 
            this.btn_taopt.AnimationHoverSpeed = 0.07F;
            this.btn_taopt.AnimationSpeed = 0.03F;
            this.btn_taopt.BackColor = System.Drawing.Color.Transparent;
            this.btn_taopt.BaseColor = System.Drawing.Color.Transparent;
            this.btn_taopt.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_taopt.BorderSize = 2;
            this.btn_taopt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_taopt.FocusedColor = System.Drawing.Color.Empty;
            this.btn_taopt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taopt.ForeColor = System.Drawing.Color.LightGray;
            this.btn_taopt.Image = null;
            this.btn_taopt.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_taopt.Location = new System.Drawing.Point(522, 118);
            this.btn_taopt.Name = "btn_taopt";
            this.btn_taopt.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_taopt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_taopt.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_taopt.OnHoverImage = null;
            this.btn_taopt.OnPressedColor = System.Drawing.Color.Black;
            this.btn_taopt.Radius = 20;
            this.btn_taopt.Size = new System.Drawing.Size(130, 59);
            this.btn_taopt.TabIndex = 18;
            this.btn_taopt.Text = "Tạo phiếu thu";
            this.btn_taopt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_taopt.Click += new System.EventHandler(this.btn_taopt_Click);
            // 
            // txt_tienthieu
            // 
            this.txt_tienthieu.BaseColor = System.Drawing.Color.White;
            this.txt_tienthieu.BorderColor = System.Drawing.Color.Silver;
            this.txt_tienthieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tienthieu.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tienthieu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tienthieu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tienthieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tienthieu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_tienthieu.Location = new System.Drawing.Point(564, 447);
            this.txt_tienthieu.Name = "txt_tienthieu";
            this.txt_tienthieu.PasswordChar = '\0';
            this.txt_tienthieu.SelectedText = "";
            this.txt_tienthieu.Size = new System.Drawing.Size(179, 30);
            this.txt_tienthieu.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(387, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Số tiền cần phải nộp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(742, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "VND";
            // 
            // Form_PhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tienthieu);
            this.Controls.Add(this.btn_taopt);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.btn_xuatpt);
            this.Controls.Add(this.btn_timpt);
            this.Controls.Add(this.data_phieuthu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_PhieuThu";
            this.Text = "Form_PhieuThu";
            ((System.ComponentModel.ISupportInitialize)(this.data_phieuthu)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_phieuthu;
        private Guna.UI.WinForms.GunaButton btn_timpt;
        private Guna.UI.WinForms.GunaButton btn_xuatpt;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txt_sopt;
        private Guna.UI.WinForms.GunaTextBox txt_hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txt_mahd;
        private Guna.UI.WinForms.GunaTextBox txt_tienthu;
        private Guna.UI.WinForms.GunaButton btn_taopt;
        private Guna.UI.WinForms.GunaTextBox txt_tienthieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}