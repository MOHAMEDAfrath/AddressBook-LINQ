using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_LINQ
{
    public class GetDataTables
    {
        public static DataTable GetTable()
        {
            DataTable addressbook = new DataTable();
            //Add columns
            addressbook.Columns.Add("ContactId",typeof(int));
            addressbook.Columns.Add("FirstName",typeof(string));
            addressbook.Columns.Add("LastName",typeof(string));
            addressbook.Columns.Add("Address", typeof(string));
            addressbook.Columns.Add("City", typeof(string));
            addressbook.Columns.Add("State", typeof(string));
            addressbook.Columns.Add("ZipCode", typeof(string));
            addressbook.Columns.Add("PhoneNumber",typeof(long));
            addressbook.Columns.Add("Email",typeof(string));
            //add rows
            addressbook.Rows.Add(1, "Amir", "Khan", "Egmore", "Chennai", "TamilNadu", "600009", 7874157898, "amir.khan@gmail.com");
            addressbook.Rows.Add(2, "Dhanush", "Raj", "Nungambakam", "Chennai", "TamilNadu", "600077", 7102354045, "Dhanush.raj@gmail.com");
            addressbook.Rows.Add(3, "Ajay", "Kumar", "Menod", "Mumbai", "Maharastra", "ZIP5864", 6145784515, "Kumar@gmail.com");
            addressbook.Rows.Add(4, "Ram", "Jai", "XXXX", "Delhi", "Delhi", "XXXXXX", 6410203045, "Ram.jai@gmail.com");
            return addressbook;
        }
        

    }
}
