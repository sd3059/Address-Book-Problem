using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
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
        public AddressBookMain()
        {
            con = new List<Contact>();
        }

        public void AddContact()
        {
            Contact contacts = new Contact();
            Console.WriteLine("First Name");
            string firstname = Console.ReadLine();
            contacts.set_firstname(firstname);
            Console.WriteLine("Last Name");
            string lastname = Console.ReadLine();
            contacts.set_lastname(lastname);
            Console.WriteLine("Address");
            string address = Console.ReadLine();
            contacts.set_address(address);
            Console.WriteLine("City");
            string city = Console.ReadLine();
            contacts.set_city(city);
            Console.WriteLine("State");
            string state = Console.ReadLine();
            contacts.set_state(state);
            Console.WriteLine("ZipCode");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            contacts.set_zipcode(zipcode);
            Console.WriteLine("Phone Number");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            contacts.set_phonenumber(phonenumber);
            Console.WriteLine("Email");
            string email = Console.ReadLine();
            contacts.set_email(email);
            con.Add(contacts);
        }
        public void display()
        {
            for (int i = 0; i < con.Count; i++)
            {
                Console.WriteLine($"\nContact : {i+1}\n");
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

        public void Edit(string Email)
        {
            int option;
            string str;
            long phno;
            int n;
            for (int i = 0; i < con.Count; i++)
            {
                if (con[i].get_Email()==Email)
                    {
                        do
                        {
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
        

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to Address Book Program");
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {


            AddressBookMain myobject = new AddressBookMain();
            myobject.DisplayMessage();
            Console.WriteLine();
            myobject.AddContact();
            myobject.display();
            Console.WriteLine();
            myobject.display();
            Console.WriteLine("\nEnter the email : ");
            string email = Console.ReadLine();
            myobject.Edit(email);

            
        }
    }
}