using System;
using System.Collections.Generic;

namespace AddressBookMB
{
    public class Program
    {
        public static Dictionary<string, List<Contacts>> addressBookStore = new Dictionary<string, List<Contacts>>();
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to address book system program !");
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("1.Add Contacts");
                Console.WriteLine("2.Edit Existing Contact");
                Console.WriteLine("3.Delete Person Details");
                Console.WriteLine("4.Close AddB");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name of the address book in which you want to add record.");
                        String bookName = Console.ReadLine();
                        AddressBookMain.addBook(bookName);
                        break;
                    case 2:
                        Console.WriteLine("Enter the name fo the address book you want to edit.");
                        String bookToEdit = Console.ReadLine();
                        Console.WriteLine("Enter the first name of the person whose record you want to edit.");
                        String recordNameToEdit = Console.ReadLine();
                        AddressBookMain.editRecord(bookToEdit, recordNameToEdit);
                        break;
                    case 3:
                        Console.WriteLine("Enter name of the address book you want to delete record in.");
                        String bookToDeleteIn = Console.ReadLine();
                        Console.WriteLine("Enter first name of the person whose record you want to delete.");
                        String recordNameToDelete = Console.ReadLine();
                        AddressBookMain.deleteRecord(recordNameToDelete, bookToDeleteIn);
                        break;
                    case 4:
                        choice = 4;
                        break;
                    default:
                        Console.WriteLine("Invalid choice !");
                        break;
                }
            }




        }
    }
}
