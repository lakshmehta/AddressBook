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
        public static void editRecord(string recordNameEdit, string bookEdit)
        {

            if (Program.addressBookStore.ContainsKey(bookEdit))
            {
                List<Contacts> book = Program.addressBookStore[bookEdit];

                foreach (Contacts record in book)
                {
                    if (book.Contains(record))
                    {
                        if (record.firstName == recordNameEdit)
                        {
                            Console.WriteLine("Select Data To Update \n1.First_Name \n2.Last_Name \n3.Address" +
                                                   "\n4.City \n5.State \n6.Zip \n7.PhoneNumber \n8.Email");
                            string selection = Console.ReadLine();
                            string newData;
                            switch (selection)
                            {
                                case "1":
                                    Console.WriteLine("Enter FirstName");
                                    newData = Console.ReadLine();
                                    record.firstName = newData;
                                    Console.WriteLine("Updated  Records :\n" + record.toString());

                                    break;
                                case "2":
                                    Console.WriteLine("Enter LastName");
                                    newData = Console.ReadLine();
                                    record.lastName = newData;
                                    Console.WriteLine("Updated  Records :\n" + record.toString());

                                    break;
                                case "3":
                                    Console.WriteLine("Enter Address");
                                    newData = Console.ReadLine();
                                    record.address = newData;
                                    Console.WriteLine("Updated  Records :\n" + record.toString());

                                    break;
                                case "4":
                                    Console.WriteLine("Enter City");
                                    newData = Console.ReadLine();
                                    record.city = newData;
                                    Console.WriteLine("Updated  Records :\n" + record.toString());

                                    break;
                                case "5":
                                    Console.WriteLine("Enter State");
                                    newData = Console.ReadLine();
                                    record.state = newData;
                                    Console.WriteLine("Updated  Records :\n" + record.toString());

                                    break;
                                case "6":
                                    Console.WriteLine("Enter Zip");
                                    newData = Console.ReadLine();
                                    record.zip = newData;
                                    Console.WriteLine("Updated  Records :\n" + record.toString());

                                    break;
                                case "7":
                                    Console.WriteLine("Enter PhoneNumber");
                                    newData = Console.ReadLine();
                                    record.phoneNumber = newData;
                                    Console.WriteLine("Updated Records :\n" + record.toString());

                                    break;
                                case "8":
                                    Console.WriteLine("Enter Email");
                                    newData = Console.ReadLine();
                                    record.email = newData;
                                    Console.WriteLine("Your Updated  Records :\n" + record.toString());

                                    break;
                                default:
                                    Console.WriteLine("Invalid Selection Input");
                                    break;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("FirstName: " + record.firstName + " not Exist");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Address book not Found");
            }

        }
    }
}