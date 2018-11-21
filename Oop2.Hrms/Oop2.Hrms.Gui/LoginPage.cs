using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oop2.Hrms.Data;
using Oop2.Hrms.Framework;

namespace Oop2.Hrms.Gui
{
    public partial class LoginPage : MetroFramework.Forms.MetroForm
    {
        private HRDBEntities _context = new HRDBEntities();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var userinfo = _context.UserInfoes.FirstOrDefault(u => u.Email == txtEmail.Text && u.Password == txtPassword.Text);

                if (userinfo == null)
                {
                    MessageBox.Show("Invalid Email or Password");
                }
                else
                {
                    if (userinfo.StatusID == (int)EnumCollection.UserStatusEnum.Rejected)
                    {
                        MessageBox.Show("You are not permitted");
                        return;
                    }

                    LoginHelper.UserID = userinfo.ID;
                    if (userinfo.TypeID == (int)EnumCollection.UserTypeEnum.Admin)
                    {
                       HomePage admin = new HomePage();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        EmployeeHomePage user = new EmployeeHomePage();
                        user.Show();
                        this.Hide();
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
