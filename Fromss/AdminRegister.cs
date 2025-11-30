using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement.Fromss
{
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
           
                string correctName = "Ecem";
                string correctPassword = "123";

                string enteredName = TxtName.Text.Trim();
                string enteredPassword = TxtPassword.Text.Trim();

                if (enteredName == correctName && enteredPassword == correctPassword)
                {
                    AdminSign adminSign = new AdminSign();
                    adminSign.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
