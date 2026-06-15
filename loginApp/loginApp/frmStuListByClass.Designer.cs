namespace loginApp
{
    partial class frmStuListByClass
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
            this.lbNameClass = new System.Windows.Forms.Label();
            this.dgvStuListByClass = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.clnStuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuListByClass)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameClass
            // 
            this.lbNameClass.AutoSize = true;
            this.lbNameClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameClass.Location = new System.Drawing.Point(299, 9);
            this.lbNameClass.Name = "lbNameClass";
            this.lbNameClass.Size = new System.Drawing.Size(201, 29);
            this.lbNameClass.TabIndex = 0;
            this.lbNameClass.Text = "Danh sách lớp A";
            // 
            // dgvStuListByClass
            // 
            this.dgvStuListByClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuListByClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnStuCode,
            this.clnStuName,
            this.clnGender,
            this.clnDob});
            this.dgvStuListByClass.Location = new System.Drawing.Point(41, 52);
            this.dgvStuListByClass.Name = "dgvStuListByClass";
            this.dgvStuListByClass.RowHeadersWidth = 51;
            this.dgvStuListByClass.RowTemplate.Height = 24;
            this.dgvStuListByClass.Size = new System.Drawing.Size(725, 310);
            this.dgvStuListByClass.TabIndex = 1;
            this.dgvStuListByClass.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStuListByClass_CellFormatting);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(304, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // clnStuCode
            // 
            this.clnStuCode.HeaderText = "Mã sinh viên";
            this.clnStuCode.MinimumWidth = 6;
            this.clnStuCode.Name = "clnStuCode";
            this.clnStuCode.Width = 125;
            // 
            // clnStuName
            // 
            this.clnStuName.HeaderText = "Tên sinh viên";
            this.clnStuName.MinimumWidth = 6;
            this.clnStuName.Name = "clnStuName";
            this.clnStuName.Width = 125;
            // 
            // clnGender
            // 
            this.clnGender.HeaderText = "Giới tinh";
            this.clnGender.MinimumWidth = 6;
            this.clnGender.Name = "clnGender";
            this.clnGender.Width = 125;
            // 
            // clnDob
            // 
            this.clnDob.HeaderText = "Ngày sinh";
            this.clnDob.MinimumWidth = 6;
            this.clnDob.Name = "clnDob";
            this.clnDob.Width = 125;
            // 
            // frmStuListByClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvStuListByClass);
            this.Controls.Add(this.lbNameClass);
            this.Name = "frmStuListByClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmStuListByClass";
            this.Load += new System.EventHandler(this.frmStuListByClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuListByClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameClass;
        private System.Windows.Forms.DataGridView dgvStuListByClass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDob;
    }
}