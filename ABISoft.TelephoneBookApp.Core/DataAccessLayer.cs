using ABISoft.TelephoneBook.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABISoft.TelephoneBookApp.Core
{
    public class DataAccessLayer
    {
        List<TelephoneBookUser> telephoneBookUsers;
        public DataAccessLayer()
        {
            DatabaseControl();
            telephoneBookUsers = new List<TelephoneBookUser>();
        }
        private void DatabaseControl()
        {
            bool directoryControl = Directory.Exists(@"C:\TelephoneBookDb");
            if (!directoryControl)
            {
                Directory.CreateDirectory(@"C:\TelephoneBookDb");
                User firstUser = new User() { 
                    Id = Guid.NewGuid(),
                    Username = "firstUser",
                    Password = "firstUser"
                };
                List<User> users = new List<User>();
                users.Add(firstUser);
                string usersJson =  Newtonsoft.Json.JsonConvert.SerializeObject(users);
                File.WriteAllText(@"C:\TelephoneBookDb\users.json", usersJson);
            }   
        }
        public int NewTelephoneBookUser(TelephoneBookUser newUser)
        {
            int result = 0;
            try
            {
                GetTelephoneBookUsers();
                telephoneBookUsers.Add(newUser);
                JsonDbUpdate();
                result = 1;
            }
            catch (Exception)
            {
                //Logging
                result = 0;
            }
            return result;
        }
        public int UpdateTelephoneBookUser(TelephoneBookUser telephoneBookUser)
        {
            int result = 0;
            try
            {
                GetTelephoneBookUsers();
                int index = telephoneBookUsers.FindIndex(u => u.Id == telephoneBookUser.Id);
                if(index > -1)
                {
                    telephoneBookUsers[index].Id = telephoneBookUser.Id;
                    telephoneBookUsers[index].Firstname = telephoneBookUser.Firstname;
                    telephoneBookUsers[index].Lastname = telephoneBookUser.Lastname;
                    telephoneBookUsers[index].PhoneNumber1 = telephoneBookUser.PhoneNumber1;
                    telephoneBookUsers[index].PhoneNumber2 = telephoneBookUser.PhoneNumber2;
                    telephoneBookUsers[index].PhoneNumber3 = telephoneBookUser.PhoneNumber3;
                    telephoneBookUsers[index].Email = telephoneBookUser.Email;
                    telephoneBookUsers[index].WebSiteUrl = telephoneBookUser.WebSiteUrl;
                    telephoneBookUsers[index].Address = telephoneBookUser.Address;
                    telephoneBookUsers[index].Description = telephoneBookUser.Description;
                }
                JsonDbUpdate();
                result = 1;
            }
            catch (Exception)
            {
                //Logging
                result = 0;
            }
            return result;
        }
        public int DeleteTelephoneBookUser(Guid id)
        {
            int result = 0;
            try
            {
                GetTelephoneBookUsers();
                TelephoneBookUser userToDelete = telephoneBookUsers.Find(u => u.Id == id);
                if(userToDelete != null)
                {
                    telephoneBookUsers.Remove(userToDelete);
                    JsonDbUpdate();
                }
                result = 1;
            }
            catch (Exception)
            {
                //Logging
                result = 0;
            }

            return result;
        }
        public List<TelephoneBookUser> GetTelephoneBookUsers()
        {
            if (File.Exists(@"C:\TelephoneBookDb\telephoneBookUsers.json"))
            {
                string telephoneBookUsersJson = File.ReadAllText(@"C:\TelephoneBookDb\telephoneBookUsers.json");
                telephoneBookUsers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TelephoneBookUser>>(telephoneBookUsersJson);
            }
            return telephoneBookUsers;
        }
        public int UserControl(User user)
        {
            int userCount = 0;
            if (File.Exists(@"C:\TelephoneBookDb\users.json"))
            {
                string usersJson = File.ReadAllText(@"C:\TelephoneBookDb\users.json");
                List<User> users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(usersJson);
                userCount = users.FindAll(u => u.Username == user.Username && u.Password == user.Password).Count();
            }
            return userCount;
        }

        #region Common Methods
        private void JsonDbUpdate()
        {
            if( telephoneBookUsers != null && telephoneBookUsers.Count > 0)
            {
                string telephoneBookUsersJson = Newtonsoft.Json.JsonConvert.SerializeObject(telephoneBookUsers);
                File.WriteAllText(@"C:\TelephoneBookDb\telephoneBookUsers.json", telephoneBookUsersJson);
            }
        }
        #endregion
    }
}
