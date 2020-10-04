using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Rishabh", "Pant", "Uttarakhand", "Moti Bagh", "UK", "rishabh@gmail.com", 499945, 7654378654);
            addressBook.ViewContact();
        }
    }
}
