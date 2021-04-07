using System;
using System.Collections.Generic;

namespace AddressBookMB
{
    public class Program
    {
        public static Dictionary<string, List<Contacts>> addressBookStore = new Dictionary<string, List<Contacts>>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            String bookName = Console.ReadLine();
            AddressBookMain.addBook(bookName);
            Console.WriteLine("Enter the name fo the address book you want to edit.");
            String bookEdit = Console.ReadLine();
            Console.WriteLine("Enter the first name of the person whose record you want to edit.");
            String recordNameEdit = Console.ReadLine();
            AddressBookMain.editRecord(recordNameEdit, bookEdit);

        }
    }
}
