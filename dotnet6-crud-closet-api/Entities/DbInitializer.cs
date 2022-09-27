using dotnet6_crud_closet_api.Helpers;
using System.Collections.Generic;

namespace dotnet6_crud_closet_api.Entities
{
    public class DbInitializer
    {
        public static void Initialize(DataContext context)
        {

            //context.Database.EnsureCreated();

            // look for any users
            if (context.Users.Any())
            {
               /* context.Users.RemoveRange(context.Users);
                context.SaveChanges();*/
                return; // DB has already been seeded
            }

            var users = new User[]
                 {
                    new User
                    {
                        Title = "Teacher",
                        FirstName = "Elaine",
                        LastName = "Davis",
                        Email="edavis@mac.com",
                        Role=Role.Admin,
                        PasswordHash="passwordhash1234"
                    },
                    new User
                    {
                        Title = "Mom",
                        FirstName = "Maureen",
                        LastName = "Kilday",
                        Email="mkilday@mac.com",
                        Role=Role.Admin,
                        PasswordHash="passwordhash1234"

                    },
                    new User
                    {
                        Title = "Student",
                        FirstName = "Jackie",
                        LastName = "Suarez",
                        Email="jsaurez@gmail.com",
                        Role=Role.User,
                        PasswordHash="passwordhash1234"
                    },
                    new User
                    {
                        Title = "Psychologist",
                        FirstName = "Bill",
                        LastName = "Stewart",
                        Email="bstewart@gmail.com",
                        Role=Role.User,
                        PasswordHash="passwordhash1234"

                    },
                    new User
                    {
                       Title = "Teacher",
                        FirstName = "Mary",
                        LastName = "Smith",
                        Email="msmith@gmail.com",
                        Role=Role.User,
                        PasswordHash="passwordhash1234"
                    },
                    new User
                    {
                        Title = "Manager",
                        FirstName = "John",
                        LastName = "Morris",
                        Email="jmorris@yahoo.com",
                        Role=Role.User,
                        PasswordHash="passwordhash1234"
                    },
                     new User
                    {
                        Title = "Student",
                        FirstName = "Jane",
                        LastName = "Doe",
                        Email="jdoe@centercityschool.edu",
                        Role=Role.User,
                        PasswordHash="passwordhash1234"
                    },
                 };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }
    }
}