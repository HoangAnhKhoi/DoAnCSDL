namespace giaodien
{
    partial class Form_DoanhThuMotThang
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
            this.btn_xuatDL = new Guna.UI.WinForms.GunaButton();
            this.btn_tinhDthu = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_tongtien = new Guna.UI.WinForms.GunaTextBox();
            this.btn_xoadl = new Guna.UI.WinForms.GunaButton();
            this.data_DoanhThu = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xuatDL
            // 
            this.btn_xuatDL.AnimationHoverSpeed = 0.07F;
            this.btn_xuatDL.AnimationSpeed = 0.03F;
            this.btn_xuatDL.BackColor = System.Drawing.Color.Transparent;
            this.btn_xuatDL.BaseColor = System.Drawing.Color.Transparent;
            this.btn_xuatDL.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xuatDL.BorderSize = 2;
            this.btn_xuatDL.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xuatDL.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xuatDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatDL.ForeColor = System.Drawing.Color.LightGray;
            this.btn_xuatDL.Image = null;
            this.btn_xuatDL.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_xuatDL.Location = new System.Drawing.Point(776, 85);
            this.btn_xuatDL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xuatDL.Name = "btn_xuatDL";
            this.btn_xuatDL.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xuatDL.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xuatDL.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xuatDL.OnHoverImage = null;
            this.btn_xuatDL.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xuatDL.Radius = 20;
            this.btn_xuatDL.Size = new System.Drawing.Size(184, 63);
            this.btn_xuatDL.TabIndex = 18;
            this.btn_xuatDL.Text = "Xuất dữ liệu";
            this.btn_xuatDL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xuatDL.Click += new System.EventHandler(this.btn_xuatDL_Click);
            // 
            // btn_tinhDthu
            // 
            this.btn_tinhDthu.AnimationHoverSpeed = 0.07F;
            this.btn_tinhDthu.AnimationSpeed = 0.03F;
            this.btn_tinhDthu.BackColor = System.Drawing.Color.Transparent;
            this.btn_tinhDthu.BaseColor = System.Drawing.Color.Transparent;
            this.btn_tinhDthu.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tinhDthu.BorderSize = 2;
            this.btn_tinhDthu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_tinhDthu.FocusedColor = System.Drawing.Color.Empty;
            this.btn_tinhDthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhDthu.ForeColor = System.Drawing.Color.LightGray;
            this.btn_tinhDthu.Image = null;
            this.btn_tinhDthu.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_tinhDthu.Location = new System.Drawing.Point(776, 15);
            this.btn_tinhDthu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_tinhDthu.Name = "btn_tinhDthu";
            this.btn_tinhDthu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_tinhDthu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_tinhDthu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_tinhDthu.OnHoverImage = null;
            this.btn_tinhDthu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_tinhDthu.Radius = 20;
            this.btn_tinhDthu.Size = new System.Drawing.Size(184, 63);
            this.btn_tinhDthu.TabIndex = 17;
            this.btn_tinhDthu.Text = "Tính doanh thu";
            this.btn_tinhDthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_tinhDthu.Click += new System.EventHandler(this.btn_tinhDthu_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.date_to);
            this.gunaGroupBox1.Controls.Add(this.date_from);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(16, 15);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(695, 133);
            this.gunaGroupBox1.TabIndex = 16;
            this.gunaGroupBox1.Text = "    Doanh thu tháng";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(180, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(325, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "-";
            // 
            // date_to
            // 
            this.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_to.Location = new System.Drawing.Point(425, 70);
            this.date_to.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(171, 34);
            this.date_to.TabIndex = 9;
            // 
            // date_from
            // 
            this.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_from.Location = new System.Drawing.Point(88, 70);
            this.date_from.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(171, 34);
            this.date_from.TabIndex = 8;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gunaLabel3.Location = new System.Drawing.Point(561, 540);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(111, 28);
            this.gunaLabel3.TabIndex = 19;
            this.gunaLabel3.Text = "Tổng tiền :";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BaseColor = System.Drawing.Color.White;
            this.txt_tongtien.BorderColor = System.Drawing.Color.Silver;
            this.txt_tongtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tongtien.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tongtien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tongtien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tongtien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tongtien.Location = new System.Drawing.Point(744, 529);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.PasswordChar = '\0';
            this.txt_tongtien.SelectedText = "";
            this.txt_tongtien.Size = new System.Drawing.Size(296, 37);
            this.txt_tongtien.TabIndex = 20;
            // 
            // btn_xoadl
            // 
            this.btn_xoadl.AnimationHoverSpeed = 0.07F;
            this.btn_xoadl.AnimationSpeed = 0.03F;
            this.btn_xoadl.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoadl.BaseColor = System.Drawing.Color.Transparent;
            this.btn_xoadl.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoadl.BorderSize = 2;
            this.btn_xoadl.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoadl.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoadl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoadl.ForeColor = System.Drawing.Color.LightGray;
            this.btn_xoadl.Image = null;
            this.btn_xoadl.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_xoadl.Location = new System.Drawing.Point(16, 517);
            this.btn_xoadl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoadl.Name = "btn_xoadl";
            this.btn_xoadl.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xoadl.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoadl.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoadl.OnHoverImage = null;
            this.btn_xoadl.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoadl.Radius = 20;
            this.btn_xoadl.Size = new System.Drawing.Size(216, 63);
            this.btn_xoadl.TabIndex = 21;
            this.btn_xoadl.Text = "Xóa dữ liệu của tháng";
            this.btn_xoadl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoadl.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // data_DoanhThu
            // 
            this.data_DoanhThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_DoanhThu.ColumnHeadersHeight = 35;
            this.data_DoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2,
            this.dataGridViewButtonColumn3,
            this.Column4});
            this.data_DoanhThu.Location = new System.Drawing.Point(16, 167);
            this.data_DoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_DoanhThu.Name = "data_DoanhThu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DoanhThu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_DoanhThu.RowHeadersVisible = false;
            this.data_DoanhThu.RowHeadersWidth = 51;
            this.data_DoanhThu.Size = new System.Drawing.Size(1024, 342);
            this.data_DoanhThu.TabIndex = 22;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.HeaderText = "Mã hợp đồng";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn2.HeaderText = "Ngày tạo hợp đồng";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn3.HeaderText = "Ngày hoàn thành";
            this.dataGridViewButtonColumn3.MinimumWidth = 6;
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Số tiền thu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form_DoanhThuMotThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1056, 593);
            this.Controls.Add(this.data_DoanhThu);
            this.Controls.Add(this.btn_xoadl);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.btn_xuatDL);
            this.Controls.Add(this.btn_tinhDthu);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_DoanhThuMotThang";
            this.Text = "Form_DoanhThuMotThang";
            this.Load += new System.EventHandler(this.Form_DoanhThuMotThang_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_xuatDL;
        private Guna.UI.WinForms.GunaButton btn_tinhDthu;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txt_tongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.DateTimePicker date_from;
        private Guna.UI.WinForms.GunaButton btn_xoadl;
        private System.Windows.Forms.DataGridView data_DoanhThu;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}