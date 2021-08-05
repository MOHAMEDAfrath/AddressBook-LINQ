using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_LINQ
{
   public class TableOperations
    {
        public static DataTable InsertIntoDataTable(AddressBookModel addressBookModel)
        {
            DataTable dataTable = GetDataTables.GetTable();
            dataTable.Rows.Add(addressBookModel.contactId,addressBookModel.FirstName,addressBookModel.LastName,addressBookModel.Address,addressBookModel.City,addressBookModel.State,addressBookModel.ZipCode,addressBookModel.Phonenumber,addressBookModel.email);
            return dataTable;
        }
        
    }
}
