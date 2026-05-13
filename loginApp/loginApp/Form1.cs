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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = "0002068@st.huce.edu.vn";
            string mssv = "0002068";

            string username = txtUsername.Text; 
            string password = txtPasswd.Text;

            if (username == email && password == mssv)
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ. Đăng nhập thất bại!");
            }
        }
    }
}
