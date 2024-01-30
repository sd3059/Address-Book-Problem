using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ABS
{
    class Contact
    {
        private string First_Name;
        private string Last_Name;
        private string Address;
        private string City;
        private string State;
        private int ZipCode;
        private long PhoneNumber;
        private string Email;
        public string get_firstname()
        {
            return this.First_Name;
        }
        public void set_firstname(string First)
        {
            this.First_Name = First;
        }
        public string get_lastname()
        {
            return this.Last_Name;
        }
        public void set_lastname(string Last)
        {
            this.Last_Name = Last;
        }
        public string get_address()
        {
            return this.Address;
        }
        public void set_address(string Address)
        {
            this.Address = Address;
        }
        public string get_City()
        {
            return this.City;
        }
        public void set_city(string City)
        {
            this.City = City;
        }
        public string get_State()
        {
            return this.State;
        }
        public void set_state(string State)
        {
            this.State = State;
        }
        public int get_ZipCode()
        {
            return this.ZipCode;
        }
        public void set_zipcode(int ZipCode)
        {
            this.ZipCode = ZipCode;
        }
        public long get_PhoneNumber()
        {
            return this.PhoneNumber;
        }
        public void set_phonenumber(long PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
        public string get_Email()
        {
            return this.Email;
        }
        public void set_email(string Email)
        {
            this.Email = Email;
        }
    }

    class AddressBookMain
    {
        List<Contact> con;
        public AddressBookMain(SortedDictionary<string, List<Contact>> address)
        {
            con = new List<Contact>();
            string str = Console.ReadLine();
            address[str] = con;
        }

        public void AddContact()
        {
            Contact contacts = new Contact();
            Console.Write("First Name : ");
            string firstname = Console.ReadLine();
            contacts.set_firstname(firstname);
            Console.Write("Last Name : ");
            string lastname = Console.ReadLine();
            contacts.set_lastname(lastname);
            Console.Write("Address : ");
            string address = Console.ReadLine();
            contacts.set_address(address);
            Console.Write("City : ");
            string city = Console.ReadLine();
            contacts.set_city(city);
            Console.Write("State : ");
            string state = Console.ReadLine();
            contacts.set_state(state);
            Console.Write("ZipCode : ");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            contacts.set_zipcode(zipcode);
            Console.Write("Phone Number : ");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            contacts.set_phonenumber(phonenumber);
            Console.Write("Email : ");
            string email = Console.ReadLine();
            contacts.set_email(email);
            con.Add(contacts);
        }
        public void display()
        {
            for (int i = 0; i < con.Count; i++)
            {
                Console.WriteLine($"\nContact : {i + 1}\n");
                Console.WriteLine($"First Name : {con[i].get_firstname()}");
                Console.WriteLine($"Last Name : {con[i].get_lastname()}");
                Console.WriteLine($"Address : {con[i].get_address()}");
                Console.WriteLine($"City : {con[i].get_City()}");
                Console.WriteLine($"State : {con[i].get_State()}");
                Console.WriteLine($"Zip Code : {con[i].get_ZipCode()}");
                Console.WriteLine($"Phone Number : {con[i].get_PhoneNumber()}");
                Console.WriteLine($"Email : {con[i].get_Email()}");
            }
        }
        public void display2(Contact cont)
        {
            Console.WriteLine($"First Name : {cont.get_firstname()}");
            Console.WriteLine($"Last Name : {cont.get_lastname()}");
            Console.WriteLine($"Address : {cont.get_address()}");
            Console.WriteLine($"City : {cont.get_City()}");
            Console.WriteLine($"State : {cont.get_State()}");
            Console.WriteLine($"Zip Code : {cont.get_ZipCode()}");
            Console.WriteLine($"Phone Number : {cont.get_PhoneNumber()}");
            Console.WriteLine($"Email : {cont.get_Email()}");
        }

        public void Edit(string Email)
        {
            int option;
            string str;
            long phno;
            int n;
            for (int i = 0; i < con.Count; i++)
            {
                if (con[i].get_Email() == Email)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine();
                        display2(con[i]);
                        Console.WriteLine();
                        Console.WriteLine("Enter which portion to be edited ..");
                        Console.WriteLine("1. FirstName\n2. Last Name\n3. Address\n4. City\n5. State\n6. ZipCode\n7. Phone Number\n8. Email\n9. Done");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter the First New Name : ");
                                str = Console.ReadLine();
                                con[i].set_firstname(str);
                                break;
                            case 2:
                                Console.WriteLine("Enter the Last New Name : ");
                                str = Console.ReadLine();
                                con[i].set_lastname(str);
                                break;
                            case 3:
                                Console.WriteLine("Enter the New Address : ");
                                str = Console.ReadLine();
                                con[i].set_address(str);
                                break;
                            case 4:
                                Console.WriteLine("Enter the New City : ");
                                str = Console.ReadLine();
                                con[i].set_city(str);
                                break;
                            case 5:
                                Console.WriteLine("Enter the New State : ");
                                str = Console.ReadLine();
                                con[i].set_state(str);
                                break;
                            case 6:
                                Console.WriteLine("Enter the New ZipCode : ");
                                n = Convert.ToInt32(Console.ReadLine());
                                con[i].set_zipcode(n);
                                break;
                            case 7:
                                Console.WriteLine("Enter the New Phone Number : ");
                                phno = Convert.ToInt64(Console.ReadLine());
                                con[i].set_phonenumber(phno);
                                break;
                            case 8:
                                Console.WriteLine("Enter the New Email : ");
                                str = Console.ReadLine();
                                con[i].set_email(str);
                                break;
                            case 9:
                                Console.WriteLine("All Edits done..");
                                break;
                        }
                    } while (option != 9);
                }
            }
        }
        public void delete(string email)
        {
            int flag = 0;
            for (int i = 0; i < con.Count; i++)
            {
                if (con[i].get_Email() == email)
                {
                    Console.Clear();
                    display2(con[i]);
                    Console.WriteLine("Do you want to delete this Contact : (Y/N)");
                    string str = Console.ReadLine();
                    if (str == "y" || str == "Y")
                    {
                        con.Remove(con[i]);
                        Console.WriteLine("Contact has been deleted ...");
                    }
                    else
                    {
                        Console.WriteLine("Contact is not deleted ...");
                    }
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"The email id \"{email}\" does not match with any contact");
            }
        }

        public void switching (string name, SortedDictionary<string, List<Contact>> dict)
        {
            con=dict[name];
        }
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to Address Book Program");
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Contact>> address_books = new SortedDictionary<string, List<Contact>>();
            Console.WriteLine("Enter the owner of the Address Book : ");
            AddressBookMain myobject = new AddressBookMain(address_books);
            Console.Clear();
            int option;
            string email;
            myobject.DisplayMessage();
            Thread.Sleep(2000);
            do
            {
                Console.Clear();
                Console.WriteLine("Enter an option from the menu : \n\n1. Add Contact\n2. Display Contacts\n3. Edit Contact\n4. Delete Contact\n5. Add a new address book\n6. Display address books\n7. Switch to another book\n8. Exit\n");
                option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1: Console.Clear();
                            myobject.AddContact();
                            Console.Clear();
                            Console.WriteLine("Contact Added Successfully ...");
                            Thread.Sleep(2000);
                            break;
                    case 2: Console.Clear();
                            myobject.display();
                            Console.WriteLine("\nPress any key to go back ...");
                            Console.ReadKey();
                            break;
                    case 3: Console.Clear();
                            myobject.display();
                            Console.WriteLine("\nEnter the email of the contact to edit : ");
                            email= Console.ReadLine();
                            myobject.Edit(email);
                            Console.WriteLine("Contact Edited ...");
                            Thread.Sleep(2000);
                            break;
                    case 4: Console.Clear();
                            myobject.display();
                            Console.WriteLine("\nEnter the email of the contact to be deleted : ");
                            email = Console.ReadLine();
                            myobject.delete(email);
                            Thread.Sleep(2000);
                            break;
                    case 5: Console.Clear();
                            Console.WriteLine("Enter the new address book : ");
                            myobject = new AddressBookMain(address_books);
                            Console.WriteLine("New address book has been created ...");
                            Thread.Sleep(3000);
                            break;
                    case 6: Console.Clear();
                            foreach(KeyValuePair<string, List<Contact>> kvp in address_books)
                            {
                                Console.WriteLine($"{kvp.Key} : {kvp.Value.Count} Contacts");
                            }
                            Console.WriteLine("\n Press Any Key to go back ...");
                            Console.ReadKey();
                            break;
                    case 7: Console.Clear();
                            foreach (KeyValuePair<string, List<Contact>> kvp in address_books)
                            {
                                Console.WriteLine($"{kvp.Key} : {kvp.Value.Count} Contacts");
                            }
                            Console.WriteLine("\nEnter the Address book to switch with ...");
                            email=Console.ReadLine();
                            if (address_books.ContainsKey(email))
                            {
                                myobject.switching(email, address_books);
                                Console.WriteLine($"Switched to {email}");
                            }
                            else
                            {
                                Console.WriteLine("The Specified Address book does not exist ...");
                            }
                            Thread.Sleep(3000);
                            break;
                    case 8: Console.WriteLine("Exited ...");
                            break;
                }
            } while (option != 8);
                       
        }
    }
}