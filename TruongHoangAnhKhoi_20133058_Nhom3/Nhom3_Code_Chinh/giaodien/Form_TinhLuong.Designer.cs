namespace giaodien
{
    partial class Form_TinhLuong
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
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_luongKT = new System.Windows.Forms.DateTimePicker();
            this.date_luongBD = new System.Windows.Forms.DateTimePicker();
            this.btn_tinhluong = new Guna.UI.WinForms.GunaButton();
            this.btn_xuatdata = new Guna.UI.WinForms.GunaButton();
            this.data_Luong = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Luong)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.date_luongKT);
            this.gunaGroupBox1.Controls.Add(this.date_luongBD);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(521, 108);
            this.gunaGroupBox1.TabIndex = 6;
            this.gunaGroupBox1.Text = " Thời gian tính lương";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(180, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(253, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "-";
            // 
            // date_luongKT
            // 
            this.date_luongKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_luongKT.Location = new System.Drawing.Point(317, 57);
            this.date_luongKT.Name = "date_luongKT";
            this.date_luongKT.Size = new System.Drawing.Size(129, 29);
            this.date_luongKT.TabIndex = 10;
            // 
            // date_luongBD
            // 
            this.date_luongBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_luongBD.Location = new System.Drawing.Point(66, 57);
            this.date_luongBD.Name = "date_luongBD";
            this.date_luongBD.Size = new System.Drawing.Size(129, 29);
            this.date_luongBD.TabIndex = 9;
            // 
            // btn_tinhluong
            // 
            this.btn_tinhluong.AnimationHoverSpeed = 0.07F;
            this.btn_tinhluong.AnimationSpeed = 0.03F;
            this.btn_tinhluong.BackColor = System.Drawing.Color.Transparent;
            this.btn_tinhluong.BaseColor = System.Drawing.Color.Transparent;
            this.btn_tinhluong.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tinhluong.BorderSize = 2;
            this.btn_tinhluong.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_tinhluong.FocusedColor = System.Drawing.Color.Empty;
            this.btn_tinhluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhluong.ForeColor = System.Drawing.Color.LightGray;
            this.btn_tinhluong.Image = null;
            this.btn_tinhluong.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_tinhluong.Location = new System.Drawing.Point(582, 12);
            this.btn_tinhluong.Name = "btn_tinhluong";
            this.btn_tinhluong.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_tinhluong.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_tinhluong.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_tinhluong.OnHoverImage = null;
            this.btn_tinhluong.OnPressedColor = System.Drawing.Color.Black;
            this.btn_tinhluong.Radius = 20;
            this.btn_tinhluong.Size = new System.Drawing.Size(138, 51);
            this.btn_tinhluong.TabIndex = 14;
            this.btn_tinhluong.Text = "Tính lương";
            this.btn_tinhluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_tinhluong.Click += new System.EventHandler(this.gunaButton2_Click_1);
            // 
            // btn_xuatdata
            // 
            this.btn_xuatdata.AnimationHoverSpeed = 0.07F;
            this.btn_xuatdata.AnimationSpeed = 0.03F;
            this.btn_xuatdata.BackColor = System.Drawing.Color.Transparent;
            this.btn_xuatdata.BaseColor = System.Drawing.Color.Transparent;
            this.btn_xuatdata.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xuatdata.BorderSize = 2;
            this.btn_xuatdata.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xuatdata.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xuatdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatdata.ForeColor = System.Drawing.Color.LightGray;
            this.btn_xuatdata.Image = null;
            this.btn_xuatdata.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_xuatdata.Location = new System.Drawing.Point(582, 69);
            this.btn_xuatdata.Name = "btn_xuatdata";
            this.btn_xuatdata.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xuatdata.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xuatdata.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xuatdata.OnHoverImage = null;
            this.btn_xuatdata.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xuatdata.Radius = 20;
            this.btn_xuatdata.Size = new System.Drawing.Size(138, 51);
            this.btn_xuatdata.TabIndex = 15;
            this.btn_xuatdata.Text = "Xuất dữ liệu";
            this.btn_xuatdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xuatdata.Click += new System.EventHandler(this.btn_xuatdata_Click);
            // 
            // data_Luong
            // 
            this.data_Luong.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Luong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_Luong.ColumnHeadersHeight = 41;
            this.data_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_Luong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2,
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn4,
            this.dataGridViewButtonColumn5});
            this.data_Luong.Location = new System.Drawing.Point(12, 138);
            this.data_Luong.Name = "data_Luong";
            this.data_Luong.RowHeadersVisible = false;
            this.data_Luong.RowHeadersWidth = 51;
            this.data_Luong.Size = new System.Drawing.Size(768, 332);
            this.data_Luong.TabIndex = 16;
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn5.HeaderText = "Tổng tiền lương";
            this.dataGridViewButtonColumn5.MinimumWidth = 6;
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            this.dataGridViewButtonColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn4.HeaderText = "Hoa hồng";
            this.dataGridViewButtonColumn4.MinimumWidth = 6;
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn3.HeaderText = "Lương cứng";
            this.dataGridViewButtonColumn3.MinimumWidth = 6;
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn2.HeaderText = "Tên nhân viên";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.HeaderText = "Mã nhân viên";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form_TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(792, 482);
            this.Controls.Add(this.data_Luong);
            this.Controls.Add(this.btn_xuatdata);
            this.Controls.Add(this.btn_tinhluong);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_TinhLuong";
            this.Text = "Form_TinhLuong";
            this.Load += new System.EventHandler(this.Form_TinhLuong_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Luong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton btn_tinhluong;
        private Guna.UI.WinForms.GunaButton btn_xuatdata;
        private System.Windows.Forms.DateTimePicker date_luongBD;
        private System.Windows.Forms.DateTimePicker date_luongKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_Luong;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn5;
    }
}