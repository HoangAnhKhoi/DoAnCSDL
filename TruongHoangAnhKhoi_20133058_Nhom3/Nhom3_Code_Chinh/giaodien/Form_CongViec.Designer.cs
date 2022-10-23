namespace giaodien
{
    partial class Form_CongViec
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
            this.data_cv = new System.Windows.Forms.DataGridView();
            this.btn_suacv = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txt_tiencv = new Guna.UI.WinForms.GunaTextBox();
            this.txt_tienhh = new Guna.UI.WinForms.GunaTextBox();
            this.txt_macv = new Guna.UI.WinForms.GunaTextBox();
            this.txt_ndcv = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_xoacv = new Guna.UI.WinForms.GunaButton();
            this.btn_themcv = new Guna.UI.WinForms.GunaButton();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_cv)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_cv
            // 
            this.data_cv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_cv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_cv.ColumnHeadersHeight = 40;
            this.data_cv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_cv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data_cv.Location = new System.Drawing.Point(12, 217);
            this.data_cv.Name = "data_cv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_cv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_cv.RowHeadersVisible = false;
            this.data_cv.RowHeadersWidth = 51;
            this.data_cv.Size = new System.Drawing.Size(768, 255);
            this.data_cv.TabIndex = 2;
            this.data_cv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_cv_CellClick);
            // 
            // btn_suacv
            // 
            this.btn_suacv.AnimationHoverSpeed = 0.07F;
            this.btn_suacv.AnimationSpeed = 0.03F;
            this.btn_suacv.BackColor = System.Drawing.Color.Transparent;
            this.btn_suacv.BaseColor = System.Drawing.Color.Transparent;
            this.btn_suacv.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suacv.BorderSize = 2;
            this.btn_suacv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_suacv.FocusedColor = System.Drawing.Color.Empty;
            this.btn_suacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suacv.ForeColor = System.Drawing.Color.LightGray;
            this.btn_suacv.Image = null;
            this.btn_suacv.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_suacv.Location = new System.Drawing.Point(644, 88);
            this.btn_suacv.Name = "btn_suacv";
            this.btn_suacv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_suacv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_suacv.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_suacv.OnHoverImage = null;
            this.btn_suacv.OnPressedColor = System.Drawing.Color.Black;
            this.btn_suacv.Radius = 20;
            this.btn_suacv.Size = new System.Drawing.Size(138, 51);
            this.btn_suacv.TabIndex = 24;
            this.btn_suacv.Text = "Sửa công việc";
            this.btn_suacv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_suacv.Click += new System.EventHandler(this.btn_suacv_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.DimGray;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.txt_tiencv);
            this.gunaGroupBox1.Controls.Add(this.txt_tienhh);
            this.gunaGroupBox1.Controls.Add(this.txt_macv);
            this.gunaGroupBox1.Controls.Add(this.txt_ndcv);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 9);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(622, 200);
            this.gunaGroupBox1.TabIndex = 21;
            this.gunaGroupBox1.Text = "Thông tin công việc";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(230, 4);
            // 
            // txt_tiencv
            // 
            this.txt_tiencv.BaseColor = System.Drawing.Color.White;
            this.txt_tiencv.BorderColor = System.Drawing.Color.Silver;
            this.txt_tiencv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tiencv.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tiencv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tiencv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tiencv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tiencv.ForeColor = System.Drawing.Color.Black;
            this.txt_tiencv.Location = new System.Drawing.Point(343, 74);
            this.txt_tiencv.Name = "txt_tiencv";
            this.txt_tiencv.PasswordChar = '\0';
            this.txt_tiencv.SelectedText = "";
            this.txt_tiencv.Size = new System.Drawing.Size(267, 30);
            this.txt_tiencv.TabIndex = 19;
            this.txt_tiencv.TextChanged += new System.EventHandler(this.txt_tiencv_TextChanged);
            this.txt_tiencv.Leave += new System.EventHandler(this.txt_tiencv_Leave);
            // 
            // txt_tienhh
            // 
            this.txt_tienhh.BaseColor = System.Drawing.Color.White;
            this.txt_tienhh.BorderColor = System.Drawing.Color.Silver;
            this.txt_tienhh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tienhh.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tienhh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tienhh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tienhh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tienhh.ForeColor = System.Drawing.Color.Black;
            this.txt_tienhh.Location = new System.Drawing.Point(343, 157);
            this.txt_tienhh.Name = "txt_tienhh";
            this.txt_tienhh.PasswordChar = '\0';
            this.txt_tienhh.SelectedText = "";
            this.txt_tienhh.Size = new System.Drawing.Size(267, 30);
            this.txt_tienhh.TabIndex = 18;
            this.txt_tienhh.Leave += new System.EventHandler(this.txt_tienhh_Leave);
            // 
            // txt_macv
            // 
            this.txt_macv.BaseColor = System.Drawing.Color.White;
            this.txt_macv.BorderColor = System.Drawing.Color.Silver;
            this.txt_macv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_macv.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_macv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_macv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_macv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_macv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_macv.Location = new System.Drawing.Point(10, 74);
            this.txt_macv.Name = "txt_macv";
            this.txt_macv.PasswordChar = '\0';
            this.txt_macv.SelectedText = "";
            this.txt_macv.Size = new System.Drawing.Size(267, 30);
            this.txt_macv.TabIndex = 17;
            // 
            // txt_ndcv
            // 
            this.txt_ndcv.BaseColor = System.Drawing.Color.White;
            this.txt_ndcv.BorderColor = System.Drawing.Color.Silver;
            this.txt_ndcv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ndcv.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_ndcv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ndcv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ndcv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ndcv.ForeColor = System.Drawing.Color.Black;
            this.txt_ndcv.Location = new System.Drawing.Point(10, 157);
            this.txt_ndcv.Name = "txt_ndcv";
            this.txt_ndcv.PasswordChar = '\0';
            this.txt_ndcv.SelectedText = "";
            this.txt_ndcv.Size = new System.Drawing.Size(267, 30);
            this.txt_ndcv.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nội dung công việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã công việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(340, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tiền công việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(340, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiền hoa hồng";
            // 
            // btn_xoacv
            // 
            this.btn_xoacv.AnimationHoverSpeed = 0.07F;
            this.btn_xoacv.AnimationSpeed = 0.03F;
            this.btn_xoacv.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoacv.BaseColor = System.Drawing.Color.Transparent;
            this.btn_xoacv.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoacv.BorderSize = 2;
            this.btn_xoacv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoacv.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoacv.ForeColor = System.Drawing.Color.LightGray;
            this.btn_xoacv.Image = null;
            this.btn_xoacv.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_xoacv.Location = new System.Drawing.Point(644, 155);
            this.btn_xoacv.Name = "btn_xoacv";
            this.btn_xoacv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xoacv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoacv.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoacv.OnHoverImage = null;
            this.btn_xoacv.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoacv.Radius = 20;
            this.btn_xoacv.Size = new System.Drawing.Size(138, 51);
            this.btn_xoacv.TabIndex = 22;
            this.btn_xoacv.Text = "Xoá công việc";
            this.btn_xoacv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoacv.Click += new System.EventHandler(this.btn_xoacv_Click);
            // 
            // btn_themcv
            // 
            this.btn_themcv.AnimationHoverSpeed = 0.07F;
            this.btn_themcv.AnimationSpeed = 0.03F;
            this.btn_themcv.BackColor = System.Drawing.Color.Transparent;
            this.btn_themcv.BaseColor = System.Drawing.Color.Transparent;
            this.btn_themcv.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themcv.BorderSize = 2;
            this.btn_themcv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_themcv.FocusedColor = System.Drawing.Color.Empty;
            this.btn_themcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themcv.ForeColor = System.Drawing.Color.LightGray;
            this.btn_themcv.Image = null;
            this.btn_themcv.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_themcv.Location = new System.Drawing.Point(644, 21);
            this.btn_themcv.Name = "btn_themcv";
            this.btn_themcv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_themcv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_themcv.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_themcv.OnHoverImage = null;
            this.btn_themcv.OnPressedColor = System.Drawing.Color.Black;
            this.btn_themcv.Radius = 20;
            this.btn_themcv.Size = new System.Drawing.Size(138, 51);
            this.btn_themcv.TabIndex = 23;
            this.btn_themcv.Text = "Thêm công việc";
            this.btn_themcv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_themcv.Click += new System.EventHandler(this.btn_themcv_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã công việc";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Nội dung công việc";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Tiền công việc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Tiền hoa hồng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form_CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(792, 482);
            this.Controls.Add(this.btn_suacv);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.btn_xoacv);
            this.Controls.Add(this.btn_themcv);
            this.Controls.Add(this.data_cv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CongViec";
            this.Text = "Form_CongViec";
            this.Load += new System.EventHandler(this.Form_CongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_cv)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_cv;
        private Guna.UI.WinForms.GunaButton btn_suacv;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txt_tiencv;
        private Guna.UI.WinForms.GunaTextBox txt_tienhh;
        private Guna.UI.WinForms.GunaTextBox txt_macv;
        private Guna.UI.WinForms.GunaTextBox txt_ndcv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btn_xoacv;
        private Guna.UI.WinForms.GunaButton btn_themcv;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}