using System;
using System.Collections.Generic;
using MyGram.Models;
using System.Linq;

namespace MyGram
{
    class Program
    {
        static void Main()
        {
            List<User> userList = new List<User>();

            User newUser1 = new User();
            newUser1.Email = "email1@somewhere.com";
            newUser1.Paswword = "Password1";
            newUser1.UserId = 1;
            newUser1.UserName = "DjJunior1";
            userList.Add(newUser1);

            User newUser2 = new User();
            newUser2.Email = "email2@somewhere.com";
            newUser2.Paswword = "Password2";
            newUser2.UserId = 2;
            newUser2.UserName = "Cynthia2";
            userList.Add(newUser2);

            User newUser3 = new User();
            newUser3.Email = "email3@somewhere.com";
            newUser3.Paswword = "Password3";
            newUser3.UserId = 3;
            newUser3.UserName = "Ivy3";
            userList.Add(newUser3);

            User newUser4 = new User();
            newUser4.Email = "email4@somewhere.com";
            newUser4.Paswword = "Password4";
            newUser4.UserId = 4;
            newUser4.UserName = "Amari";
            userList.Add(newUser4);

            User newUser5 = new User();
            newUser5.Email = "email5@somewhere.com";
            newUser5.Paswword = "Password5";
            newUser5.UserId = 5;
            newUser5.UserName = "Potsi5";
            userList.Add(newUser5);

            User newUser6 = new User();
            newUser6.Email = "email6@somewhere.com";
            newUser6.Paswword = "Password6";
            newUser6.UserId = 6;
            newUser6.UserName = "Trini6";
            userList.Add(newUser6);

            User newUser7 = new User();
            newUser7.Email = "emai7l@somewhere.com";
            newUser7.Paswword = "Password7";
            newUser7.UserId = 7;
            newUser7.UserName = "Oleta";
            userList.Add(newUser7);

            User newUser8 = new User();
            newUser8.Email = "email8@somewhere.com";
            newUser8.Paswword = "Password8";
            newUser8.UserId = 8;
            newUser8.UserName = "Korn8";
            userList.Add(newUser8);

            User newUser9 = new User();
            newUser9.Email = "email9@somewhere.com";
            newUser9.Paswword = "Password9";
            newUser9.UserId = 9;
            newUser9.UserName = "MotleyCrue";
            userList.Add(newUser9);

            User newUser10 = new User();
            newUser10.Email = "email10@somewhere.com";
            newUser10.Paswword = "Password10";
            newUser10.UserId = 10;
            newUser10.UserName = "Rafael10";
            userList.Add(newUser10);


            userList = userList.Where(user => user.UserName == "DjJunior").ToList();

            if (userList.Count > 0)
            {
                Console.WriteLine("Users found and they have the following properties: ");
                string format = "My user has these properties: " +
                                "Email: {0}, UserId: {1}, Password: {2}," +
                                "UserName: {3}";

                foreach(var user in userList)
                {
                    Conole.WriteLine(format, user.email, user.UserId,
                                     user.Password, user.Username);
                }
            }
            else
            {
                Console.WriteLine("No users found for the specified query");
            }

        }
    }
}
