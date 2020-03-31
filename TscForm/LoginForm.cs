using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MSTSCLib;
using System.IO;

namespace TscForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string str_computer = "";
        public static string str_userName = "";
        public static string str_password = "";
        public static string is_remembered = "true";

        public void bt_connect_Click(object sender, EventArgs e)
        {
            //主要是可以将此数据传递给后面打开的TSC窗体,同时若是连接成功将此数据传递给excel中的文件
            str_computer = tb_computer.Text;
            str_userName = tb_userName.Text;
            str_password = tb_password.Text;
            is_remembered = checkBox1.Checked.ToString();

            //打开新的窗体，关闭当前窗体
            TscForm frm_TSC = new TscForm();
            frm_TSC.Width = SystemInformation.WorkingArea.Width;
            frm_TSC.Height = SystemInformation.WorkingArea.Height;
            frm_TSC.WindowState = FormWindowState.Maximized;

            Hide();
            frm_TSC.ShowDialog();
            Application.Exit();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            str_computer = tb_computer.Text;
            str_userName = tb_userName.Text;
            str_password = tb_password.Text;
            is_remembered = checkBox1.Checked.ToString();

            tb_computer.Text = str_computer;
            tb_userName.Text = str_userName;
            tb_password.Text = str_password;
            checkBox1.Checked = Convert.ToBoolean(is_remembered);
        }

    }
}
