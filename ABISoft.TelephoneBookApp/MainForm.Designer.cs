
namespace ABISoft.TelephoneBookApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_List = new System.Windows.Forms.ListBox();
            this.groupBox_Record = new System.Windows.Forms.GroupBox();
            this.button_DeleteUser = new System.Windows.Forms.Button();
            this.button_UpdateUser = new System.Windows.Forms.Button();
            this.button_AddNewUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Website = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Phone3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Phone2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Phone1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_FileSituation = new System.Windows.Forms.Label();
            this.button_XmlImport = new System.Windows.Forms.Button();
            this.button_CsvExport = new System.Windows.Forms.Button();
            this.button_JsonExport = new System.Windows.Forms.Button();
            this.button_XmlExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_Record.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_List);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 575);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telephone Book Users";
            // 
            // listBox_List
            // 
            this.listBox_List.FormattingEnabled = true;
            this.listBox_List.Location = new System.Drawing.Point(7, 16);
            this.listBox_List.Name = "listBox_List";
            this.listBox_List.Size = new System.Drawing.Size(223, 537);
            this.listBox_List.TabIndex = 0;
            this.listBox_List.DoubleClick += new System.EventHandler(this.listBox_List_DoubleClick);
            // 
            // groupBox_Record
            // 
            this.groupBox_Record.Controls.Add(this.button_DeleteUser);
            this.groupBox_Record.Controls.Add(this.button_UpdateUser);
            this.groupBox_Record.Controls.Add(this.button_AddNewUser);
            this.groupBox_Record.Controls.Add(this.tabControl1);
            this.groupBox_Record.Location = new System.Drawing.Point(274, 12);
            this.groupBox_Record.Name = "groupBox_Record";
            this.groupBox_Record.Size = new System.Drawing.Size(776, 361);
            this.groupBox_Record.TabIndex = 1;
            this.groupBox_Record.TabStop = false;
            this.groupBox_Record.Text = "New Telephone Book User";
            // 
            // button_DeleteUser
            // 
            this.button_DeleteUser.Location = new System.Drawing.Point(389, 320);
            this.button_DeleteUser.Name = "button_DeleteUser";
            this.button_DeleteUser.Size = new System.Drawing.Size(373, 29);
            this.button_DeleteUser.TabIndex = 4;
            this.button_DeleteUser.Text = "Delete User";
            this.button_DeleteUser.UseVisualStyleBackColor = true;
            this.button_DeleteUser.Click += new System.EventHandler(this.button_DeleteUser_Click);
            // 
            // button_UpdateUser
            // 
            this.button_UpdateUser.Location = new System.Drawing.Point(6, 320);
            this.button_UpdateUser.Name = "button_UpdateUser";
            this.button_UpdateUser.Size = new System.Drawing.Size(373, 29);
            this.button_UpdateUser.TabIndex = 3;
            this.button_UpdateUser.Text = "Update User";
            this.button_UpdateUser.UseVisualStyleBackColor = true;
            this.button_UpdateUser.Click += new System.EventHandler(this.button_UpdateUser_Click);
            // 
            // button_AddNewUser
            // 
            this.button_AddNewUser.Location = new System.Drawing.Point(6, 285);
            this.button_AddNewUser.Name = "button_AddNewUser";
            this.button_AddNewUser.Size = new System.Drawing.Size(756, 29);
            this.button_AddNewUser.TabIndex = 2;
            this.button_AddNewUser.Text = "Add New User";
            this.button_AddNewUser.UseVisualStyleBackColor = true;
            this.button_AddNewUser.Click += new System.EventHandler(this.button_AddNewUser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 250);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_Address);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox_Website);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox_Email);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox_Phone3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox_Phone2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox_Phone1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_Lastname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_Firstname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(442, 53);
            this.textBox_Address.Multiline = true;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(299, 138);
            this.textBox_Address.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adress";
            // 
            // textBox_Website
            // 
            this.textBox_Website.Location = new System.Drawing.Point(86, 182);
            this.textBox_Website.Name = "textBox_Website";
            this.textBox_Website.Size = new System.Drawing.Size(340, 20);
            this.textBox_Website.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Website";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(86, 156);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(340, 20);
            this.textBox_Email.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // textBox_Phone3
            // 
            this.textBox_Phone3.Location = new System.Drawing.Point(86, 131);
            this.textBox_Phone3.Name = "textBox_Phone3";
            this.textBox_Phone3.Size = new System.Drawing.Size(340, 20);
            this.textBox_Phone3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone3";
            // 
            // textBox_Phone2
            // 
            this.textBox_Phone2.Location = new System.Drawing.Point(86, 105);
            this.textBox_Phone2.Name = "textBox_Phone2";
            this.textBox_Phone2.Size = new System.Drawing.Size(340, 20);
            this.textBox_Phone2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone2";
            // 
            // textBox_Phone1
            // 
            this.textBox_Phone1.Location = new System.Drawing.Point(86, 79);
            this.textBox_Phone1.Name = "textBox_Phone1";
            this.textBox_Phone1.Size = new System.Drawing.Size(340, 20);
            this.textBox_Phone1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone1";
            // 
            // textBox_Lastname
            // 
            this.textBox_Lastname.Location = new System.Drawing.Point(86, 53);
            this.textBox_Lastname.Name = "textBox_Lastname";
            this.textBox_Lastname.Size = new System.Drawing.Size(340, 20);
            this.textBox_Lastname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lastname";
            // 
            // textBox_Firstname
            // 
            this.textBox_Firstname.Location = new System.Drawing.Point(86, 27);
            this.textBox_Firstname.Name = "textBox_Firstname";
            this.textBox_Firstname.Size = new System.Drawing.Size(340, 20);
            this.textBox_Firstname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_Description);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Description";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(6, 6);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(744, 236);
            this.textBox_Description.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_FileSituation);
            this.groupBox3.Controls.Add(this.button_XmlImport);
            this.groupBox3.Controls.Add(this.button_CsvExport);
            this.groupBox3.Controls.Add(this.button_JsonExport);
            this.groupBox3.Controls.Add(this.button_XmlExport);
            this.groupBox3.Location = new System.Drawing.Point(274, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Import/Export";
            // 
            // label_FileSituation
            // 
            this.label_FileSituation.AutoSize = true;
            this.label_FileSituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FileSituation.Location = new System.Drawing.Point(613, 50);
            this.label_FileSituation.Name = "label_FileSituation";
            this.label_FileSituation.Size = new System.Drawing.Size(122, 17);
            this.label_FileSituation.TabIndex = 4;
            this.label_FileSituation.Text = "Situation : Waiting";
            // 
            // button_XmlImport
            // 
            this.button_XmlImport.Location = new System.Drawing.Point(452, 31);
            this.button_XmlImport.Name = "button_XmlImport";
            this.button_XmlImport.Size = new System.Drawing.Size(137, 54);
            this.button_XmlImport.TabIndex = 3;
            this.button_XmlImport.Text = "XML IMPORT";
            this.button_XmlImport.UseVisualStyleBackColor = true;
            // 
            // button_CsvExport
            // 
            this.button_CsvExport.Location = new System.Drawing.Point(309, 31);
            this.button_CsvExport.Name = "button_CsvExport";
            this.button_CsvExport.Size = new System.Drawing.Size(137, 54);
            this.button_CsvExport.TabIndex = 2;
            this.button_CsvExport.Text = "CSV EXPORT";
            this.button_CsvExport.UseVisualStyleBackColor = true;
            this.button_CsvExport.Click += new System.EventHandler(this.button_CsvExport_Click);
            // 
            // button_JsonExport
            // 
            this.button_JsonExport.Location = new System.Drawing.Point(164, 31);
            this.button_JsonExport.Name = "button_JsonExport";
            this.button_JsonExport.Size = new System.Drawing.Size(137, 54);
            this.button_JsonExport.TabIndex = 1;
            this.button_JsonExport.Text = "JSOIN_EXPORT";
            this.button_JsonExport.UseVisualStyleBackColor = true;
            // 
            // button_XmlExport
            // 
            this.button_XmlExport.Location = new System.Drawing.Point(21, 31);
            this.button_XmlExport.Name = "button_XmlExport";
            this.button_XmlExport.Size = new System.Drawing.Size(137, 54);
            this.button_XmlExport.TabIndex = 0;
            this.button_XmlExport.Text = "XML EXPORT";
            this.button_XmlExport.UseVisualStyleBackColor = true;
            this.button_XmlExport.Click += new System.EventHandler(this.button_XmlExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 599);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Record);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Telephone Book";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Record.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Record;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_Lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Website;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Phone3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Phone2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Phone1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AddNewUser;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.ListBox listBox_List;
        private System.Windows.Forms.Button button_UpdateUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_FileSituation;
        private System.Windows.Forms.Button button_XmlImport;
        private System.Windows.Forms.Button button_CsvExport;
        private System.Windows.Forms.Button button_JsonExport;
        private System.Windows.Forms.Button button_XmlExport;
        private System.Windows.Forms.Button button_DeleteUser;
    }
}