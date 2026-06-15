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
    public partial class frmStuListByClass : Form
    {
        databaseDataContext db = new databaseDataContext();

        private string className;
        private string classCode;
        public frmStuListByClass(string classCode, string className)
        {
            InitializeComponent();
            this.classCode = classCode;
            this.className = className;
        }

        private void frmStuListByClass_Load(object sender, EventArgs e)
        {
            var lop = db.lophocs.FirstOrDefault(x => x.classCode == classCode);
            if (lop == null)
            {
                MessageBox.Show("Không tìm thấy lớp học!");
                return;
            }
            else
            {
                lbNameClass.Text = "Danh sách sinh viên lớp " + lop.className;
                dgvStuListByClass.AutoGenerateColumns = false;
                clnStuCode.DataPropertyName = "studentCode";
                clnStuName.DataPropertyName = "studentName";
                clnGender.DataPropertyName = "gender";
                clnDob.DataPropertyName = "bthDay";
                dgvStuListByClass.DataSource = lop.sinhviens.Where(x => x.classID == lop.classID).ToList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvStuListByClass_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStuListByClass.Columns[e.ColumnIndex].Name == "clnGender" && e.Value != null)
            {
                e.Value = (bool)e.Value ? "Nữ" : "Nam";
                e.FormattingApplied = true;
            }
        }
    }
}
