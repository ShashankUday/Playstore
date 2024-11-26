using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    public class User:IUser1
    {
        // properties
        public int Id { get; set; }            // class properties( get set )
        public string Name { get; set; }    // public int a; variable property
        public string Email { get; set; }
        public string Password { get; set; }
        public int Mobile  { get; set; }

        private int UserKey { get; set; }

        public void AddUser()
        {
            
        }


        // Functions or Method
        public void CreateUser()
        {
            Console.WriteLine("User Registration");
            //how to read and enter the user details or  inout from keyboard
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Welcome " +Name);
            Console.WriteLine("Enter Email");
            Email = Console.ReadLine();
            Console.WriteLine("Ur Email is "+Email);
            Console.WriteLine("Enter Mobile");
            Mobile = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ur mobile is " + Mobile);
            Console.WriteLine("Enter Userkey");
            UserKey = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User Key is " + UserKey);
        }

        public void DeleteUser()
        {
        }

        public void GetUser()
        {
        }

        public void UpdateUser()
        {
        }
    }
}
