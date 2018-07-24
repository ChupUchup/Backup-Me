using System;
using SQLibrary;

namespace test_SQLibrary
{
    
    class Program
    {
        //enum dbType { SQLite, mySQL, SQLServer };
        static void Main(string[] args)
        {
            Console.Title = "test SQLibrary";
            do
            {
                Console.Clear();
                //try
                //{
                    SQLite Lite = new SQLite("Datasource=db_lite.db");
                    Console.WriteLine(Lite.ConnString);
                    foreach (string i in Lite.Table) Console.WriteLine(i);
                //}
                //catch (Exception ex) { Console.WriteLine(ex.Message); }

                Console.Write("lagi ? Y/T : ");
            } while (char.ToUpper(Console.ReadKey().KeyChar) != 'T');
        }
    }
}
