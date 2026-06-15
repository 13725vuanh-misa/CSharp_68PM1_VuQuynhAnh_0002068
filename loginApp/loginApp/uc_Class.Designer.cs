namespace loginApp
{
    partial class uc_Class
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
            this.InputStudentForm = new System.Windows.Forms.Panel();
            this.btnViewStd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClassDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStdView = new System.Windows.Forms.DataGridView();
            this.btnFrist = new System.Windows.Forms.Button();
            this.btnFindClass = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputStudentForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdView)).BeginInit();
            this.SuspendLayout();
            // 
            // InputStudentForm
            // 
            this.InputStudentForm.AccessibleDescription = "";
            this.InputStudentForm.Controls.Add(this.btnViewStd);
            this.InputStudentForm.Controls.Add(this.btnReload);
            this.InputStudentForm.Controls.Add(this.btnDeleteClass);
            this.InputStudentForm.Controls.Add(this.btnEditClass);
            this.InputStudentForm.Controls.Add(this.btnAddClass);
            this.InputStudentForm.Controls.Add(this.groupBox1);
            this.InputStudentForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputStudentForm.Location = new System.Drawing.Point(3, 3);
            this.InputStudentForm.Name = "InputStudentForm";
            this.InputStudentForm.Size = new System.Drawing.Size(367, 648);
            this.InputStudentForm.TabIndex = 1;
            // 
            // btnViewStd
            // 
            this.btnViewStd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnViewStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewStd.Location = new System.Drawing.Point(6, 529);
            this.btnViewStd.Name = "btnViewStd";
            this.btnViewStd.Size = new System.Drawing.Size(343, 47);
            this.btnViewStd.TabIndex = 7;
            this.btnViewStd.Text = "Xem danh sách sinh viên";
            this.btnViewStd.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Gray;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReload.Location = new System.Drawing.Point(179, 466);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(170, 47);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteClass.Location = new System.Drawing.Point(6, 466);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(170, 47);
            this.btnDeleteClass.TabIndex = 5;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.BackColor = System.Drawing.Color.Green;
            this.btnEditClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditClass.Location = new System.Drawing.Point(179, 413);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(170, 47);
            this.btnEditClass.TabIndex = 4;
            this.btnEditClass.Text = "Sửa";
            this.btnEditClass.UseVisualStyleBackColor = false;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClass.Location = new System.Drawing.Point(6, 413);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(170, 47);
            this.btnAddClass.TabIndex = 3;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClassId);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 383);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Lớp";
            // 
            // txtClassDate
            // 
            this.txtClassDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtClassDate.Location = new System.Drawing.Point(9, 171);
            this.txtClassDate.Name = "txtClassDate";
            this.txtClassDate.Size = new System.Drawing.Size(331, 22);
            this.txtClassDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(9, 53);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(332, 22);
            this.txtClassId.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(9, 110);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(332, 22);
            this.txtClassName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStdView);
            this.panel1.Controls.Add(this.btnFrist);
            this.panel1.Controls.Add(this.btnFindClass);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(376, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 648);
            this.panel1.TabIndex = 2;
            // 
            // dgvStdView
            // 
            this.dgvStdView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.ClassName,
            this.CreateAt});
            this.dgvStdView.Location = new System.Drawing.Point(35, 122);
            this.dgvStdView.Name = "dgvStdView";
            this.dgvStdView.RowHeadersWidth = 51;
            this.dgvStdView.RowTemplate.Height = 24;
            this.dgvStdView.Size = new System.Drawing.Size(714, 379);
            this.dgvStdView.TabIndex = 4;
            this.dgvStdView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStdView_CellClick);
            // 
            // btnFrist
            // 
            this.btnFrist.Location = new System.Drawing.Point(206, 544);
            this.btnFrist.Name = "btnFrist";
            this.btnFrist.Size = new System.Drawing.Size(37, 32);
            this.btnFrist.TabIndex = 5;
            this.btnFrist.Text = "<<";
            this.btnFrist.UseVisualStyleBackColor = true;
            this.btnFrist.Click += new System.EventHandler(this.btnFrist_Click);
            // 
            // btnFindClass
            // 
            this.btnFindClass.Location = new System.Drawing.Point(550, 544);
            this.btnFindClass.Name = "btnFindClass";
            this.btnFindClass.Size = new System.Drawing.Size(37, 32);
            this.btnFindClass.TabIndex = 5;
            this.btnFindClass.Text = ">>";
            this.btnFindClass.UseVisualStyleBackColor = true;
            this.btnFindClass.Click += new System.EventHandler(this.btnFindClass_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(495, 544);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 32);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(266, 544);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(37, 32);
            this.btnPre.TabIndex = 5;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Trang 1/1 | 0 bản ghi";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnFind.Location = new System.Drawing.Point(359, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(103, 46);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(6, 40);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(324, 22);
            this.txtFind.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm kiếm (Mã lớp/Tên lớp)";
            // 
            // CreateAt
            // 
            this.CreateAt.HeaderText = "Ngày tạo";
            this.CreateAt.MinimumWidth = 6;
            this.CreateAt.Name = "CreateAt";
            this.CreateAt.Width = 125;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Tên lớp";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.Width = 125;
            // 
            // ClassID
            // 
            this.ClassID.HeaderText = "Mã lớp";
            this.ClassID.MinimumWidth = 6;
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Width = 125;
            // 
            // uc_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputStudentForm);
            this.Name = "uc_Class";
            this.Size = new System.Drawing.Size(1145, 654);
            this.Load += new System.EventHandler(this.uc_Class_Load);
            this.InputStudentForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel InputStudentForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtClassDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dgvStdView;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFrist;
        private System.Windows.Forms.Button btnFindClass;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnViewStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateAt;
    }
}