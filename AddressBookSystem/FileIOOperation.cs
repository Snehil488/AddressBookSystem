using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookSystem
{
    class FileIOOperation
    {
        public void WriteToFile(Dictionary<string, AddressBook> addressBookDictionary)
        {
            using StreamWriter writer = new StreamWriter(@"C:\Users\Snehil\Desktop\Local Git Repo\AddressBookSystem\AddressBookSystem\AddressBookRecord.txt", true);
            foreach (AddressBook addressBookobj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookobj.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Text File");
            string lines = File.ReadAllText(@"C:\Users\Snehil\Desktop\Local Git Repo\AddressBookSystem\AddressBookSystem\AddressBookRecord.txt");
            Console.WriteLine(lines);
        }
    }
}
