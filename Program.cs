using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ABS
{
    class AddressBookMain
    {
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


        }
    }
}
