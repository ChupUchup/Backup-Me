using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SQLite;

namespace test_query
{
    class Program
    {
        //using mysql
        //static void Main(string[] args)
        //{
        //    Console.Title = "test_query";
        //    var conn = new MySqlConnection("Server=localhost; Uid=root;");
        //    string q = "SHOW DATABASES";
        //    try
        //    {
        //        conn.Open();
        //        //var cmd = new MySqlCommand(q, conn);
        //        //Console.WriteLine(cmd.ExecuteNonQuery());
        //        //MySqlDataReader reader = cmd.ExecuteReader();
        //        var da = new MySqlDataAdapter(q, conn);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds);
        //        for (int i = 0; i < ds.Tables.Count; i++)
        //        {
        //            for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
        //            {
        //                for (int k = 0; k < ds.Tables[i].Columns.Count; k++)
        //                {
        //                    Console.Write(ds.Tables[i].Rows[j].ItemArray[k]);
        //                }
        //            }
        //        }
                
                
                
        //    }
        //    catch (MySqlException ex) { Console.WriteLine(string.Concat(ex.Number, ex.Message)); }
        //    finally { conn.Close(); }

        //    Console.ReadKey();
        //}

        //using sqlite
        static void Main(string[] args)
        {
            Console.Title = "test sqlite";
            do{
                Console.Clear();
                string cs = "Data Source=";
                int select = 0;
                string dbName = null, tblName = null;
                Console.WriteLine("1. List Table");
                Console.WriteLine("2. Create Table");
                Console.WriteLine("3. Create Database");
                Console.Write("Pilih menu : ");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            Console.WriteLine();
                            using (var conn = new SQLiteConnection(cs + "db_lite.db"))
                            {
                                try
                                {
                                    conn.Open();
                                    string q = "SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY 1;";
                                    using (var da = new SQLiteDataAdapter(q, conn))
                                    {
                                        var ds = new DataSet();
                                        da.Fill(ds);
                                        //Console.WriteLine(ds.Tables.Count);
                                        for (int i = 0; i < ds.Tables.Count; i++)
                                        {
                                            for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
                                            {
                                                for (int k = 0; k < ds.Tables[i].Columns.Count; k++)
                                                {
                                                    Console.Write(ds.Tables[i].Rows[j].ItemArray[k]);
                                                }
                                                Console.WriteLine();
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex) { Console.WriteLine(ex.Message); }
                                finally { conn.Close(); }
                            }
                            break;
                        case 2:
                            Console.Write("Input nama table : ");
                            tblName = Console.ReadLine();
                            using (var conn = new SQLiteConnection(cs + "db_lite.db"))
                            {
                                try
                                {
                                    conn.Open();
                                    string q = "CREATE TABLE " + tblName + " (_id int not null, _nama varchar(30) not null);";
                                    using (var cmd = new SQLiteCommand(q, conn))
                                    {
                                        cmd.ExecuteNonQuery();
                                        Console.WriteLine("table " + tblName + " telah di buat");
                                    }
                                }
                                catch (Exception ex) { Console.WriteLine(ex.Message); }
                                finally { conn.Close(); }
                            }
                            break;
                        case 3:
                            Console.Write("Input nama database : ");
                            dbName = Console.ReadLine();
                            try { SQLiteConnection.CreateFile(dbName); Console.WriteLine("database " + dbName + " telah di buat"); }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                            break;
                        default:
                            Console.WriteLine("Input diluar range");
                            break;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                Console.Write("\nLagi ? Y/T");
            } while (char.ToUpper(Console.ReadKey().KeyChar) != 'T');
            
        }
    }
}
