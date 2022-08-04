using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    // A database class that stores users in a list and allows us to perform following operations:
    // Insert
    // Find
    // Update
    // Remove
    // ListAll

    
    internal class UserDatabaseUsingList
    {
        private string DBName { get; set; }
        private List<User> Users { get; set; }    // List<User> Users must be private since it's element "User" is a private class.
        public UserDatabaseUsingList(string name)
        {
            this.Users = new List<User>();
            this.DBName = name;
        }

        // Insert operation: Inserting a user object
        public void Insert(string username, string name, string email)
        {
            //Loop through each element of the users list and insert user at index where user.Username<users[i].Username.
            int i = 0;
            while (i < Users.Count)
            {
                if (String.Compare(username, Users[i].Username) == 0)
                {
                    Console.WriteLine("User {0} already exists.", username);
                    Console.WriteLine();
                    return;
                }
                if (String.Compare(username, Users[i].Username) < 0)
                {
                    break;
                }
                i++;
            }
            User user = new User(username, name, email);
            Users.Insert(i, user);
            Console.WriteLine("User {0} added to the database {1}", username, this.DBName);
            Console.WriteLine();
        }

        // Find the details of a user by Username
        public void Find(string username)
        {
            foreach (User i in this.Users)
            {
                if (i.Username.Equals(username))
                {
                    Console.WriteLine(username + ": " + i);
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("User {0} not found.", username);
            Console.WriteLine();
        }

        // Update a User
        public void Update(string username, string newUsername, string newName, string newEmail)
        {
            foreach (User i in this.Users)
            {
                if (i.Username.Equals(username))
                {
                    i.Username = newUsername;
                    i.Name = newName;
                    i.Email = newEmail;
                    Console.WriteLine("User {0} updated.", username);
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("User {0} doesn't exist.", username);
            Console.WriteLine();
        }


        // Remove a user by Username
        public void Remove(string username)
        {
            foreach (User i in this.Users)
            {
                if (i.Username.Equals(username))
                {
                    this.Users.Remove(i);
                    Console.WriteLine("User {0} removed from database {1}.", username, this.DBName);
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("User {0} not found.", username);
            Console.WriteLine();
        }

        // ListAll method which lists all the stored users details
        public void ListAll()
        {
            Console.WriteLine("List of Users:");
            foreach (User i in this.Users)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        // create a user class to store info of a user
        private class User
        {
            public string Username { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }

            public User(string username, string name, string email)
            {
                this.Username = username;
                this.Name = name;
                this.Email = email;
                //Console.WriteLine("User {0} Created!", this.Username);
            }
            public void IntroduceYourself(string guestName)
            {
                Console.WriteLine("Hi {0}, I'm {1}! Contact me at {2}.", guestName, this.Name, this.Email);
            }
            // Display User Properties by printing the User object directly.
            public override string ToString()
            {
                return String.Format("User(Username = {0}, Name = {1}, Email = {2})", this.Username, this.Name, this.Email);
            }
        }
    }
}
