using ABISoft.TelephoneBook.Entities;
using ABISoft.TelephoneBookApp.Core;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ABISoft.TelephoneBookApp.Business
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dataLogicLayer;
        public BusinessLogicLayer()
        {
            dataLogicLayer = new DataAccessLayer();
        }

        public int NewTelephoneBookUser(Guid id, string firstName, string lastName, string phoneNumber1, string phoneNumber2, string phoneNumber3, 
            string address, string email, string websiteUrl, string description )
        {
            int result = 0;
            //Bunlar dışındakiler opsiyonel
            if(id != Guid.Empty && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(phoneNumber1))
            {
                TelephoneBookUser telephoneBookUser = new TelephoneBookUser();
                telephoneBookUser.Id = id;
                telephoneBookUser.Firstname = firstName;
                telephoneBookUser.Lastname = lastName;
                telephoneBookUser.PhoneNumber1 = phoneNumber1;
                telephoneBookUser.PhoneNumber2 = phoneNumber2;
                telephoneBookUser.PhoneNumber3 = phoneNumber3;
                telephoneBookUser.Email = email;
                telephoneBookUser.Address = address;
                telephoneBookUser.WebSiteUrl = websiteUrl;
                telephoneBookUser.Description = description;
                result = dataLogicLayer.NewTelephoneBookUser(telephoneBookUser);
            }
            else
            {
                result = -100; //Missing Parameter Error Code
            }
            return result;
        }
        public int UpdateTelephoneBookUser(Guid id, string firstName, string lastName, string phoneNumber1, string phoneNumber2, string phoneNumber3,
            string address, string email, string websiteUrl, string description)
        {
            int result = 0;
            if(id != Guid.Empty && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(phoneNumber1))
            {
                TelephoneBookUser telephoneBookUser = new TelephoneBookUser();
                telephoneBookUser.Id = id;
                telephoneBookUser.Firstname = firstName;
                telephoneBookUser.Lastname = lastName;
                telephoneBookUser.PhoneNumber1 = phoneNumber1;
                telephoneBookUser.PhoneNumber2 = phoneNumber2;
                telephoneBookUser.PhoneNumber3 = phoneNumber3;
                telephoneBookUser.Email = email;
                telephoneBookUser.Address = address;
                telephoneBookUser.WebSiteUrl = websiteUrl;
                telephoneBookUser.Description = description;
                result = dataLogicLayer.UpdateTelephoneBookUser(telephoneBookUser);
            }
            else
            {
                result = -100; //Missing Parameter Error Code
            }
            return result;
        }
        public int UserControl(string username, string password)
        {
            int result = 0;
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                User user = new User();
                user.Username = username;
                user.Password = password;
                result = dataLogicLayer.UserControl(user);
            }
            else
            {
                result = -100; //Missing Parameter Error
            }
            return result;
        }
        public List<TelephoneBookUser> GetTelephoneBookUsers()
        {
            return dataLogicLayer.GetTelephoneBookUsers();
        }
        public int DeleteTelephoneBookUser(Guid id)
        {
            int result = 0;
            if(id != Guid.Empty)
            {
                dataLogicLayer.DeleteTelephoneBookUser(id);
                result = 1;
            }
            else
            {
                result = -101; //Missing Id Error
            } 
            return result;
        }
        public int XMLDataExport()
        {
            int result = 0;
            try
            {
                List<TelephoneBookUser> telephoneBookUsers = dataLogicLayer.GetTelephoneBookUsers();
                XDocument document = new XDocument(
                    new XDeclaration("1.0.0.1", "UTF-8", "yes"), 
                        new XElement("TelephoneBookUsers",
                            telephoneBookUsers.Select(u => new XElement("User", 
                                                      new XElement("Id",u.Id),
                                                      new XElement("Firstname", u.Firstname),
                                                      new XElement("Lastname", u.Lastname),
                                                      new XElement("PhoneNumber1", u.PhoneNumber1),
                                                      new XElement("PhoneNumber2", u.PhoneNumber2),
                                                      new XElement("PhoneNumber3", u.PhoneNumber3),
                                                      new XElement("Address", u.Address),
                                                      new XElement("Email", u.Email),
                                                      new XElement("WebSiteUrl", u.WebSiteUrl),
                                                      new XElement("Description", u.Description)
                ))));
                document.Save(@"C:\TelephoneBookDb\telephoneBookUsersXML.xml");
                result = 1;
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        public int CSVDataExport()
        {
            int result = 0;
            try
            {
                List<TelephoneBookUser> telephoneBookUsers = dataLogicLayer.GetTelephoneBookUsers();
                StreamWriter sw = new StreamWriter(@"C:\TelephoneBookDb\telephoneBookUsersCSV.csv");
                CsvWriter writer = new CsvWriter(sw);
                writer.WriteHeader(typeof(TelephoneBookUser));
                foreach (var user in telephoneBookUsers)
                    writer.WriteRecord(user);
                sw.Close();
                result = 1;
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
    }
}
