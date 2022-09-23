using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABISoft.TelephoneBook.Entities
{
    public class TelephoneBookUser
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string PhoneNumber3 { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string WebSiteUrl { get; set; }
        public string Description { get; set; }

        public override string ToString() //List üzerinde buradaki return edilen değeri gösteriyoruz!!
        {
            string fullName = Firstname + " " + Lastname;
            return fullName;
        }
    }
}
