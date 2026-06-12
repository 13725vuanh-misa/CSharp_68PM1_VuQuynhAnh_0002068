using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginApp
{

    public partial class ucStudent : UserControl
    {
        databaseDataContext db = new databaseDataContext();
        public ucStudent()
        {
            InitializeComponent();
        }

        void loadData()
        {
            dgvStdView.AutoGenerateColumns = false;
            List<sinhvien> dbSV = db.sinhviens.ToList();
            StdID.DataPropertyName = "studentCode";
            Column1.DataPropertyName = "studentName";
            Column2.DataPropertyName = "gender";
            Column3.DataPropertyName = "bthDay";
            Column4.DataPropertyName = "classID";
            dgvStdView.DataSource = dbSV;

            cbClass.DataSource = db.lophocs.ToList();
            cbClass.DisplayMember = "className";
            cbClass.ValueMember = "classID";
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
    }
}
