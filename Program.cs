using System;
using System.Collections.Generic;
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
        Contact contact;
        public AddressBookMain()
        {
            contact = new Contact();
        }

        public void AddContact()
        {
            Console.WriteLine("First Name");
            string firstname = Console.ReadLine();
            contact.set_firstname(firstname);
            Console.WriteLine("Last Name");
            string lastname = Console.ReadLine();
            contact.set_lastname(lastname);
            Console.WriteLine("Address");
            string address = Console.ReadLine();
            contact.set_address(address);
            Console.WriteLine("City");
            string city = Console.ReadLine();
            contact.set_city(city);
            Console.WriteLine("State");
            string state = Console.ReadLine();
            contact.set_state(state);
            Console.WriteLine("ZipCode");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            contact.set_zipcode(zipcode);
            Console.WriteLine("Phone Number");
            long phonenumber = Convert.ToInt32(Console.ReadLine());
            contact.set_phonenumber(phonenumber);
            Console.WriteLine("Email");
            string email = Console.ReadLine();
            contact.set_email(email);

        }
        public void display()
        {
            Console.WriteLine($"First Name : {contact.get_firstname()}");
            Console.WriteLine($"Last Name : {contact.get_lastname()}");
            Console.WriteLine($"Address : {contact.get_address()}");
            Console.WriteLine($"City : {contact.get_City()}");
            Console.WriteLine($"State : {contact.get_State()}");
            Console.WriteLine($"Zip Code : {contact.get_ZipCode()}");
            Console.WriteLine($"Phone Number : {contact.get_PhoneNumber()}");
            Console.WriteLine($"Email : {contact.get_Email()}");
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

        }
    }
}