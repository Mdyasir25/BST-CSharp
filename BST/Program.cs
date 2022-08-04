using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BST
{
    internal class Program
    {
        static UserDatabaseUsingList db = new UserDatabaseUsingList("db");
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                //Console.WriteLine("Press C to Create a database:");
                Console.WriteLine("Press I to Insert a user: ");
                Console.WriteLine("Press F to Find a user: ");
                Console.WriteLine("Press U to Update a user: ");
                Console.WriteLine("Press R to Remove a user: ");
                Console.WriteLine("Press L to List all the users: ");
                Console.WriteLine("Press other keys to exit.");
                Console.WriteLine();
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    //case "c":
                    //    Create();
                    //    break;
                    case "i":
                        Insert();
                        break;
                    case "f":
                        Find();
                        break;
                    case "u":
                        Update();
                        break;
                    case "r":
                        Remove();
                        break;
                    case "l":
                        db.ListAll();
                        break;
                    default:
                        Console.WriteLine("Exiting Application......");
                        flag = false;
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        //static void Create()
        //{
        //    Console.Write("Enter database name: ");
        //    string name = Console.ReadLine();
        //    db = new UserDatabaseUsingList(name);
        //}
        static void Insert()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            db.Insert(username, name, email);
        }
        static void Update()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter new Username: ");
            string newUsername = Console.ReadLine();
            Console.Write("Enter new name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter new email: ");
            string newEmail = Console.ReadLine();
            db.Update(username, newUsername, newName, newEmail);
        }
        static void Find()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            db.Find(username);
        }
        static void Remove()
        {
            Console.Write("Enter a username you want to remove: ");
            string username = Console.ReadLine();
            db.Remove(username);
        }
    }
}
