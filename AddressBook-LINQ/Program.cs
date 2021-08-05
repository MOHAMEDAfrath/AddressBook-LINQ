using System;
using System.Collections.Generic;
using System.Data;

namespace AddressBook_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookModel addressBook = new AddressBookModel();
            addressBook.FirstName = "Gopi";
            addressBook.LastName = "S";
            addressBook.Address = "Lal Street";
            addressBook.City = "Bangalore";
            addressBook.State = "Karnataka";
            addressBook.ZipCode = "ZIP7451";
            addressBook.Phonenumber = 7410205065;
            addressBook.email = "Gopi@aceu.in";
            addressBook.contactId = 5;
            addressBook.addressbookname = "Technical";
            addressBook.addressBooktype = "Profession";
            DataTable dataTable = TableOperations.InsertIntoDataTable(addressBook);
            TableOperations.CountByType(dataTable);
        }
    }
}
