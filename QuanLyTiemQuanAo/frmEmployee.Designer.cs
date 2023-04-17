﻿namespace QuanLyTiemQuanAo
{
    partial class frmEmployee
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel = new DevExpress.XtraEditors.GroupControl();
            this.ckb_work_status = new System.Windows.Forms.CheckBox();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.txt_employee_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_job_id = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.txt_employee_id = new System.Windows.Forms.TextBox();
            this.txt_full_name = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1419, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyTiemQuanAo.Properties.Resources.Add_32x32;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 44);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyTiemQuanAo.Properties.Resources.Edit_32x32;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 44);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyTiemQuanAo.Properties.Resources.Trash_32x32;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 44);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyTiemQuanAo.Properties.Resources.Save_32x32;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(37, 44);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyTiemQuanAo.Properties.Resources.Undo_32x32;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(60, 44);
            this.btnHuy.Text = "Bỏ qua";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyTiemQuanAo.Properties.Resources.Action_Close_32x32;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 44);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 47);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEmployee);
            this.splitContainer1.Size = new System.Drawing.Size(1419, 472);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee_id,
            this.job_id,
            this.full_name,
            this.gender,
            this.birthday,
            this.phone,
            this.employee_address,
            this.email,
            this.work_status});
            this.dgvEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(1419, 197);
            this.dgvEmployee.TabIndex = 128;
            // 
            // employee_id
            // 
            this.employee_id.DataPropertyName = "employee_id";
            this.employee_id.HeaderText = "Mã nhân viên";
            this.employee_id.MinimumWidth = 6;
            this.employee_id.Name = "employee_id";
            this.employee_id.Width = 115;
            // 
            // job_id
            // 
            this.job_id.DataPropertyName = "job_id";
            this.job_id.HeaderText = "Công việc";
            this.job_id.MinimumWidth = 6;
            this.job_id.Name = "job_id";
            this.job_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.job_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.job_id.Width = 125;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Họ và tên";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.Width = 200;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Giới tính";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 75;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "Ngày sinh";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.Width = 175;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Số điện thoại";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 125;
            // 
            // employee_address
            // 
            this.employee_address.DataPropertyName = "employee_address";
            this.employee_address.HeaderText = "Địa chỉ";
            this.employee_address.MinimumWidth = 6;
            this.employee_address.Name = "employee_address";
            this.employee_address.Width = 225;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // work_status
            // 
            this.work_status.DataPropertyName = "work_status";
            this.work_status.HeaderText = "Tình trạng công việc";
            this.work_status.MinimumWidth = 6;
            this.work_status.Name = "work_status";
            this.work_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.work_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.work_status.Width = 125;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ckb_work_status);
            this.panel.Controls.Add(this.dtp_birthday);
            this.panel.Controls.Add(this.txt_employee_address);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.cb_job_id);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.txt_email);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.txt_phone);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.txtSearch);
            this.panel.Controls.Add(this.btnTim);
            this.panel.Controls.Add(this.cbSearch);
            this.panel.Controls.Add(this.txt_employee_id);
            this.panel.Controls.Add(this.txt_full_name);
            this.panel.Controls.Add(this.txt_gender);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1419, 271);
            this.panel.TabIndex = 2;
            this.panel.Text = "Thông tin nhân viên";
            // 
            // ckb_work_status
            // 
            this.ckb_work_status.AutoSize = true;
            this.ckb_work_status.Location = new System.Drawing.Point(1063, 125);
            this.ckb_work_status.Name = "ckb_work_status";
            this.ckb_work_status.Size = new System.Drawing.Size(18, 17);
            this.ckb_work_status.TabIndex = 229;
            this.ckb_work_status.UseVisualStyleBackColor = true;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_birthday.Location = new System.Drawing.Point(603, 126);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_birthday.Size = new System.Drawing.Size(183, 23);
            this.dtp_birthday.TabIndex = 228;
            // 
            // txt_employee_address
            // 
            this.txt_employee_address.Location = new System.Drawing.Point(1063, 55);
            this.txt_employee_address.Name = "txt_employee_address";
            this.txt_employee_address.Size = new System.Drawing.Size(250, 23);
            this.txt_employee_address.TabIndex = 227;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(913, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 226;
            this.label6.Text = "Địa chỉ";
            // 
            // cb_job_id
            // 
            this.cb_job_id.FormattingEnabled = true;
            this.cb_job_id.Location = new System.Drawing.Point(137, 123);
            this.cb_job_id.Name = "cb_job_id";
            this.cb_job_id.Size = new System.Drawing.Size(250, 24);
            this.cb_job_id.TabIndex = 225;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 224;
            this.label5.Text = "Công việc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(911, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 223;
            this.label10.Text = "Tình trạng công việc";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(1063, 88);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 23);
            this.txt_email.TabIndex = 222;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(913, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 221;
            this.label7.Text = "Email";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(603, 52);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(184, 23);
            this.txt_phone.TabIndex = 220;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 219;
            this.label1.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 218;
            this.label9.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(642, 167);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 24);
            this.txtSearch.TabIndex = 217;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(794, 165);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 32);
            this.btnTim.TabIndex = 215;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(533, 167);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(101, 24);
            this.cbSearch.TabIndex = 216;
            // 
            // txt_employee_id
            // 
            this.txt_employee_id.Location = new System.Drawing.Point(137, 53);
            this.txt_employee_id.Name = "txt_employee_id";
            this.txt_employee_id.Size = new System.Drawing.Size(250, 23);
            this.txt_employee_id.TabIndex = 214;
            // 
            // txt_full_name
            // 
            this.txt_full_name.Location = new System.Drawing.Point(137, 87);
            this.txt_full_name.Name = "txt_full_name";
            this.txt_full_name.Size = new System.Drawing.Size(250, 23);
            this.txt_full_name.TabIndex = 213;
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(603, 87);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(184, 23);
            this.txt_gender.TabIndex = 212;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 211;
            this.label8.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 210;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 209;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 208;
            this.label2.Text = "Mã nhân viên";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEmployee";
            this.Text = "Danh mục nhân viên";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn job_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn work_status;
        private DevExpress.XtraEditors.GroupControl panel;
        private System.Windows.Forms.CheckBox ckb_work_status;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.TextBox txt_employee_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_job_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox txt_employee_id;
        private System.Windows.Forms.TextBox txt_full_name;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}