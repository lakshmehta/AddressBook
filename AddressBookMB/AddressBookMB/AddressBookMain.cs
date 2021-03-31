using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookMB
{
    public class AddressBookMain
    {
        public static void contactDetails(string bookName)
        {
            Contacts pr = new Contacts();

            Console.WriteLine("Enter All Details Like: ");
            Console.WriteLine("Enter First_Name: ");
            pr.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            pr.lastName = Console.ReadLine();
            Console.WriteLine("Enter Addrees :");
            pr.address = Console.ReadLine();
            Console.WriteLine("Enter City:");
            pr.city = Console.ReadLine();
            Console.WriteLine("Enter State:");
            pr.state = Console.ReadLine();
            Console.WriteLine("Enter pin Number:");
            pr.zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            pr.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            pr.email = Console.ReadLine();

            addRecord(Program.addressBookStore[bookName], bookName, pr);


        }

        public static void addRecord(List<Contacts> book, string bookName, Contacts newRecord)
        {
            book.Add(newRecord);
            Console.WriteLine("Record added to address book [" + bookName + "]");
            Console.WriteLine(" Data :\n" + newRecord.toString());

        }
       
        public static void addBook(string bookName)
        {
            if (!Program.addressBookStore.ContainsKey(bookName))
            {
                Program.addressBookStore.Add(bookName, new List<Contacts>());
            }

            contactDetails(bookName);
        }

    }
}
