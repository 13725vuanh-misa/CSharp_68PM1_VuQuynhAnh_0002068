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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ucStudent ucQuanLiSV = new ucStudent();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(ucQuanLiSV);
        }

        private void quảnLíSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucStudent ucQuanLiSV = new ucStudent();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(ucQuanLiSV);
        }

        private void quảnLíLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uc_Class ucQuanLiLop = new uc_Class();
            
            pnl_Main.Controls.Add(ucQuanLiLop);

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFormDemocs login = new LoginFormDemocs();
            login.Show();
            this.Hide();
        }
    }
}
