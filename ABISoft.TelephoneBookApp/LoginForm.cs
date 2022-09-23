using ABISoft.TelephoneBookApp.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABISoft.TelephoneBookApp
{
    public partial class LoginForm : Form
    {
        BusinessLogicLayer bll;
        public LoginForm()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            int result = bll.UserControl(textBox_Username.Text, textBox_Password.Text);
            if(result > 0)
            {
                //Open a new form
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else if(result == -101)
            {
                MessageBox.Show("Fill the user information correctly!");
            }
            else
            {
                MessageBox.Show("Wrong User!");
            }
        }
    }
}
