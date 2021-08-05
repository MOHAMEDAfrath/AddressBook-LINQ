using AddressBook_LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace LINQ_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForInsertion()
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
            DataTable actual = TableOperations.InsertIntoDataTable(addressBook);
            int expected =5 ;
            System.Console.WriteLine(actual.Rows.Count);
            Assert.AreEqual(actual.Rows.Count, expected);
        }
    }
}
