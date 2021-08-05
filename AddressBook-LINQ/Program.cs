using System;
using System.Data;

namespace AddressBook_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataTable dataTable = GetDataTables.GetTable();
            
        }
    }
}
