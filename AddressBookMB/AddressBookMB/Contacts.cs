using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookMB
{
    public class Contacts
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public string toString()
        {
            return "FirstName: " + firstName + "\nLastName: " + lastName + "\nAddress: " + address + "\nCity: " + city + "\nState: " + state +"\nZIP: " + zip + "\nPhone_Number: " + phoneNumber + " \nEmail: " + email;
        }

    }
}
