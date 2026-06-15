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
   
    public partial class ucStudent : UserControl
    {
        databaseDataContext db = new databaseDataContext();
        public ucStudent()
        {
            InitializeComponent();
        }
        int page = 1;
        int pageSize = 2;
        
        private IQueryable<sinhvien> GetStd()
        {
            IQueryable<sinhvien> data = db.sinhviens;
            if (!string.IsNullOrEmpty(txtFind.Text.Trim()))
            {
               data = db.sinhviens.Where(s => s.studentCode.Contains(txtFind.Text.Trim()) || s.studentName.Contains(txtFind.Text.Trim()));
            }

            return data;
        }

        private List<sinhvien> GetStdPage()
        {
            return GetStd().Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        void loadData()
        {
            dgvStdView.AutoGenerateColumns = false;
            var data = GetStdPage();
            StdID.DataPropertyName = "studentCode";
            Column1.DataPropertyName = "studentName";
            Column2.DataPropertyName = "gender";
            Column3.DataPropertyName = "bthDay";
            Column4.DataPropertyName = "classID";
            dgvStdView.DataSource = data;

            cbClass.DataSource = db.lophocs.ToList();
            cbClass.DisplayMember = "className";
            cbClass.ValueMember = "classID";

            label7.Text = $"Trang {page} / {(int)Math.Ceiling((double)GetStd().Count() / pageSize)} | {GetStd().Count()} bản ghi";
        }
        private void ucStudent_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtStdId.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sinhvien sv = new sinhvien();
            sv.studentCode = txtStdId.Text;
            sv.studentName = txtName.Text;
            sv.gender = cbGender.SelectedItem.ToString() == "Nam" ? false : true;
            sv.bthDay = txtStdDate.Value;
            sv.classID = int.Parse(cbClass.SelectedValue.ToString());
            db.sinhviens.InsertOnSubmit(sv);
            db.SubmitChanges();
            loadData();
        }

        private void dgvStdView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStdView.Columns[e.ColumnIndex].Name == "Column2" && e.Value != null)
            {
                if (e.Value != null)
                {
                    bool genderValue = (bool)e.Value;
                    e.Value = genderValue ? "Nữ" : "Nam";
                    e.FormattingApplied = true;
                }
            }

            if (dgvStdView.Columns[e.ColumnIndex].Name == "Column4" && e.Value != null)
            {
                int classID = (int)e.Value;
                var classInfo = db.lophocs.FirstOrDefault(c => c.classID == classID);
                if (classInfo != null)
                {
                    e.Value = classInfo.className;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvStdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStdView.Rows[e.RowIndex];
                txtStdId.Text = row.Cells["StdID"].Value.ToString();
                txtStdId.Enabled = false;
                txtName.Text = row.Cells["Column1"].Value.ToString();
                cbGender.SelectedItem = row.Cells["Column2"].Value.ToString() == "Nam" ? "Nam" : "Nữ";
                txtStdDate.Value = Convert.ToDateTime(row.Cells["Column3"].Value);
                cbClass.SelectedValue = row.Cells["Column4"].Value;
            }
        }

        private void btnEditStd_Click(object sender, EventArgs e)
        {
            string id = txtStdId.Text;
            if (id != null)
            {
                sinhvien sv = db.sinhviens.SingleOrDefault(s => s.studentCode == id);
                if (sv != null)
                {
                    sv.studentName = txtName.Text;
                    sv.gender = cbGender.SelectedItem.ToString() == "Nam" ? false : true;
                    sv.bthDay = txtStdDate.Value;
                    sv.classID = int.Parse(cbClass.SelectedValue.ToString());
                    db.SubmitChanges();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteStd_Click(object sender, EventArgs e)
        {
            string id = txtStdId.Text;
            sinhvien sv = db.sinhviens.SingleOrDefault(s => s.studentCode == id);
            if (sv != null)
            {
                db.sinhviens.DeleteOnSubmit(sv);
                db.SubmitChanges();
                loadData();
            };
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            page = page + 1;
            if (page > (int)Math.Ceiling((double)GetStd().Count() / pageSize))
            {
                page = (int)Math.Ceiling((double)GetStd().Count() / pageSize);
                MessageBox.Show("Đây là trang cuối cùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                loadData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            page = (int)Math.Ceiling((double)GetStd().Count() / pageSize);
            loadData();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            page = page - 1;
            if (page < 1)
            {
                page = 1;
                MessageBox.Show("Đây là trang đầu tiên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            page = 1;
            loadData();
        }
    }
}
