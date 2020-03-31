using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSTSCLib;

namespace TscForm
{
    public partial class TscForm : Form
    {
        public TscForm()
        {
            InitializeComponent();
        }

        private void TscForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                axMsTscAxNotSafeForScripting1.Server = LoginForm.str_computer;
                axMsTscAxNotSafeForScripting1.UserName = LoginForm.str_userName;
                IMsTscNonScriptable secured = (IMsTscNonScriptable)axMsTscAxNotSafeForScripting1.GetOcx();
                secured.ClearTextPassword = LoginForm.str_password;
                axMsTscAxNotSafeForScripting1.Connect();

                //连接成功的话，将当前的连接信息存储到相应的按钮上


                if (!Convert.ToBoolean(LoginForm.is_remembered)) //对于不记住密码的情况，将上述记录的密码都删除掉
                {
                    
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TscForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //LoginForm fr = new LoginForm();
            //fr = (LoginForm)this.Owner;
            //fr.Dispose();
            //fr.Close();
        }

        private void TscForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LoginForm fr = new LoginForm();
            //fr = (LoginForm)this.Owner;
            //fr.Dispose();
            //fr.Close();
        }
    }
}
