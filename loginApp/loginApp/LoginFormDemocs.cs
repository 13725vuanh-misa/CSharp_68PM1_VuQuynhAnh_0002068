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
    public partial class LoginFormDemocs : Form
    {
        public LoginFormDemocs()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = "0002068@st.huce.edu.vn";
            string mssv = "0002068";

            string username = txtUsername.Text;
            string password = txtPasswd.Text;

            if (username == email && password == mssv)
            {
                MessageBox.Show("Đăng nhập thành công!");
                mainForm main = new mainForm();
                main.Show();
                this.Hide();
            }
        }

    }
}
