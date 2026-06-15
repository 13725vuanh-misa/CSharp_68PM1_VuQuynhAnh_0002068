using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginApp
{
    public partial class uc_Class : UserControl
    {
        databaseDataContext db = new databaseDataContext();
        public uc_Class()
        {
            InitializeComponent();
        }
        int page = 1;
        int pageSize = 2;

        private IQueryable<lophoc> GetClass()
        {

            IQueryable<lophoc> data = db.lophocs;
            if (string.IsNullOrEmpty(txtFind.Text.Trim()))
            {
                data = db.lophocs;
            }
            else
            {
                data = db.lophocs.Where(x => x.className.Contains(txtFind.Text.Trim()) || x.classID.ToString().Contains(txtFind.Text.Trim()));
            }
            return data;
        }

        private List<lophoc> GetClassPage()
        {
            return GetClass().Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        void loadData()
        {
            dgvStdView.AutoGenerateColumns = false;
            var data = GetClassPage();
            ClassID.DataPropertyName = "classID";
            ClassName.DataPropertyName = "className";
            CreateAt.DataPropertyName = "createAt";
            dgvStdView.DataSource = data;
            label7.Text = $"Trang {page} / {(int)Math.Ceiling((double)GetClass().Count() / pageSize)} | {GetClass().Count()} bản ghi";
        }
        private void uc_Class_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassId.Text) || string.IsNullOrEmpty(txtClassName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin lớp học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.lophocs.Any(x => x.classID.ToString() == txtClassId.Text))
            {
                MessageBox.Show("Lớp học đã tồn tại!");
            }
            else
            {
                lophoc newClass = new lophoc();
                newClass.classID = int.Parse(txtClassId.Text);
                newClass.className = txtClassName.Text;
                newClass.createAt = txtClassDate.Value;
                db.lophocs.InsertOnSubmit(newClass);
                db.SubmitChanges();
                loadData();
            }
        }

        private void dgvStdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStdView.Rows[e.RowIndex];
                txtClassId.Text = row.Cells["ClassID"].Value.ToString();
                txtClassName.Text = row.Cells["ClassName"].Value.ToString();
                txtClassDate.Value = DateTime.Parse(row.Cells["CreateAt"].Value.ToString());
                txtClassId.Enabled = false;
            }
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassId.Text;
            if (!string.IsNullOrEmpty(classId))
            {
                lophoc existingClass = db.lophocs.FirstOrDefault(x => x.classID.ToString() == classId);
                if (existingClass != null)
                {
                    existingClass.className = txtClassName.Text;
                    existingClass.createAt = txtClassDate.Value;
                    db.SubmitChanges();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Lớp học không tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp học để sửa!");
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassId.Text;
            if (!string.IsNullOrEmpty(classId))
            {
                lophoc existingClass = db.lophocs.FirstOrDefault(x => x.classID.ToString() == classId);
                if (existingClass != null)
                {
                    db.lophocs.DeleteOnSubmit(existingClass);
                    db.SubmitChanges();
                    loadData();
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtClassId.Clear();
            txtClassName.Clear();
            txtClassDate.Value = DateTime.Now;
            txtClassId.Enabled = true;
            page = 1;
            txtFind.Clear();
            loadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            page++;
            if (page > (int)Math.Ceiling((double)GetClass().Count() / pageSize))
            {
                MessageBox.Show("Bạn đã ở trang cuối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                loadData();
            }
        }

        private void btnFindClass_Click(object sender, EventArgs e)
        {
            page = (int)Math.Ceiling((double)GetClass().Count() / pageSize);
            loadData();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            page = page - 1;
            if (page < 1)
            {
                MessageBox.Show("Bạn đã ở trang đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                page = 1;
            }
            else
            {
                loadData();
            }
        }

        private void btnFrist_Click(object sender, EventArgs e)
        {
            page = 1;
            loadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            txtClassId.Clear();
            txtClassName.Clear();
            txtClassDate.Value = DateTime.Now;
            txtClassId.Enabled = true;
            page =1;
            loadData();
        }
    }
}
