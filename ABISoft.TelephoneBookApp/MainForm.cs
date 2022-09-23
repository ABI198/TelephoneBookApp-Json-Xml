using ABISoft.TelephoneBook.Entities;
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
    public partial class MainForm : Form
    {
        BusinessLogicLayer bll;
        Guid updatedUserId;
        public MainForm()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer();
        }

        private void button_AddNewUser_Click(object sender, EventArgs e)
        {
            int result = bll.NewTelephoneBookUser(Guid.NewGuid(), textBox_Firstname.Text, textBox_Lastname.Text, textBox_Phone1.Text, 
                textBox_Phone2.Text, textBox_Phone3.Text, textBox_Address.Text, textBox_Email.Text, 
                textBox_Website.Text, textBox_Description.Text);

            if(result > 0)
            {
                MessageBox.Show("User was added successfully");
                FillTelephoneBookList();
                ClearUserInformationTextBoxes();
            }
            else if(result == -100)
            {
                MessageBox.Show("Firstname, Lastname and Phonenumber1 must be filled no matter what!");
            }
            else
            {
                MessageBox.Show("An error occurred while adding user");
            }
        }

        private void FillTelephoneBookList()
        {
            List<TelephoneBookUser> telephoneBookUsers = bll.GetTelephoneBookUsers();
            if(telephoneBookUsers != null && telephoneBookUsers.Count > 0)
            {
                listBox_List.DataSource = telephoneBookUsers;
            }
        }

        private void ChangeGroupBoxTextToAdding()
        {
            groupBox_Record.Text = "New Telephone Book User";
        }

        private void ClearUserInformationTextBoxes()
        {
            textBox_Firstname.Text = "";
            textBox_Lastname.Text = "";
            textBox_Phone1.Text = "";
            textBox_Phone2.Text = "";
            textBox_Phone3.Text = "";
            textBox_Email.Text = "";
            textBox_Website.Text = "";
            textBox_Address.Text = "";
            textBox_Description.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillTelephoneBookList();
        }

        private void listBox_List_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender; //bu sender aslında listbox'ın kendisini temsil ediyor!
            TelephoneBookUser selectedTelephoneBookUser = (TelephoneBookUser)listBox.SelectedItem;
            updatedUserId = selectedTelephoneBookUser.Id;
            textBox_Firstname.Text = selectedTelephoneBookUser.Firstname;
            textBox_Lastname.Text = selectedTelephoneBookUser.Lastname;
            textBox_Phone1.Text = selectedTelephoneBookUser.PhoneNumber1;
            textBox_Phone2.Text = selectedTelephoneBookUser.PhoneNumber2;
            textBox_Phone3.Text = selectedTelephoneBookUser.PhoneNumber3;
            textBox_Address.Text = selectedTelephoneBookUser.Address;
            textBox_Email.Text = selectedTelephoneBookUser.Email;
            textBox_Website.Text = selectedTelephoneBookUser.WebSiteUrl;
            textBox_Description.Text = selectedTelephoneBookUser.Description;
            groupBox_Record.Text = "Updating Telephone Book User";
        }
        private void button_UpdateUser_Click(object sender, EventArgs e)
        {
            if(listBox_List.SelectedItem != null)
            {
                Guid id = ((TelephoneBookUser)listBox_List.SelectedItem).Id;
                int result = bll.UpdateTelephoneBookUser(id, textBox_Firstname.Text, textBox_Lastname.Text, textBox_Phone1.Text,
                    textBox_Phone2.Text, textBox_Phone3.Text, textBox_Address.Text, textBox_Email.Text,
                    textBox_Website.Text, textBox_Description.Text);
                if(result > 0)
                {
                    MessageBox.Show("User was updated successfully");
                    FillTelephoneBookList();
                    ClearUserInformationTextBoxes();
                    ChangeGroupBoxTextToAdding();
                }
                else if(result == -100)
                {
                    MessageBox.Show("Firstname, Lastname and Phonenumber1 must be filled no matter what!");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding user");
                }
            }
        }
        private void button_DeleteUser_Click(object sender, EventArgs e)
        {
            Guid selectedUserId = updatedUserId;
            int result = bll.DeleteTelephoneBookUser(selectedUserId);
            if(result > 0)
            {
                MessageBox.Show("User was deleted successfully");
                FillTelephoneBookList();
                ClearUserInformationTextBoxes();
                ChangeGroupBoxTextToAdding();
            }
            else if(result == -101)
            {
                MessageBox.Show("Id must be filled no matter what!");
            }
            else
            {
                MessageBox.Show("An error occurred while adding user");
            }
        }
        private void button_XmlExport_Click(object sender, EventArgs e)
        {
            int result = bll.XMLDataExport();
            if(result > 0)
            {
                label_FileSituation.Text = "XML Export Operation";
            }
            else
            {
                label_FileSituation.Text = "There is an error";
            }

        }
        private void button_CsvExport_Click(object sender, EventArgs e)
        {
            int result = bll.CSVDataExport();
            if(result > 0)
            {
                label_FileSituation.Text = "CSV Export Operation";
            }
            else
            {
                label_FileSituation.Text = "There is an error";
            }
        }
    }
}
