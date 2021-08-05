using AddressBook_LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;

namespace LINQ_Test
{
    [TestClass]
    public class UnitTest1
    {
        DataTable dataTable;
        [TestInitialize]
        public void SetUp()
        {
            dataTable = GetDataTables.GetTable();
        }
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
        //Test method to check updation
        [TestMethod]
        public void TestMethodForModfiyLastName()
        {
            string expected = "Success";
            string actual = TableOperations.ModifyLastName(dataTable,"Jhan","Amir");
            Assert.AreEqual(expected,actual);
        }
        //Test method to check updation wrong name
        [TestMethod]
        public void NegativeTestMethodForModfiyLastName()
        {
            string expected = "Failure";
            string actual = TableOperations.ModifyLastName(dataTable, "Jhan", "Al");
            Assert.AreEqual(expected, actual);
        }
        //TestMethod To Check Deletion of a row
        [TestMethod]
        public void TestMethodForDeletion()
        {
            string expected = "Success";
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
            DataTable dataTable1 = TableOperations.InsertIntoDataTable(addressBook);
            string actual = TableOperations.DeleteaPerson(dataTable1 ,"Gopi");
            Assert.AreEqual(expected, actual);
        }
        //Test method to check updation wrong name
        [TestMethod]
        public void NegativeTestMethodForDeletion()
        {
            string expected = "Failure";
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
            DataTable dataTable1 = TableOperations.InsertIntoDataTable(addressBook);
            string actual = TableOperations.DeleteaPerson(dataTable1, "Gopio");
            Assert.AreEqual(expected, actual);
        }
        //retrieve based on city name is checked
        [TestMethod]
        public void TestMethodToCheckRetrievalBasedOnCityName()
        {
            List<string> actual = TableOperations.RetrieveDataBasedOnCityName(dataTable,"Chennai");
            string[] temp = { "Amir Khan", "Dhanush Raj" };
            var expected = new List<string>(temp);
            CollectionAssert.AreEqual(actual,expected);
        }
        //Test method to check retrieval count based on city and state name
        [TestMethod]
        public void TestMethodToRetrieveCountBasedOnCityAndStateName()
        {
            List<string> actual = TableOperations.RetrieveCountBasedOnCityAndStateName(dataTable);
            string[] temp = { "Chennai TamilNadu 2", "Mumbai Maharastra 1","Delhi Delhi 1" };
            var expected = new List<string>(temp);
            CollectionAssert.AreEqual(actual, expected);
        }
        

    }
}
