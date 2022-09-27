using dotnet6_crud_closet_api.Entities;
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
               context.Users.RemoveRange(context.Users);
                context.SaveChanges();
               // return; // DB has already been seeded
            }

                var elaine = new User
                {
                    Title = "Teacher",
                    FirstName = "Elaine",
                    LastName = "Davis",
                    Email="edavis@mac.com",
                    Role=Role.Admin,
                    PasswordHash="passwordhash1234"
                };
                var maureen = new User
                {
                    Title = "Mom",
                    FirstName = "Maureen",
                    LastName = "Kilday",
                    Email = "mkilday@mac.com",
                    Role = Role.Admin,
                    PasswordHash = "passwordhash1234"

                };
                var jackie = new User
                {
                    Title = "Student",
                    FirstName = "Jackie",
                    LastName = "Suarez",
                    Email = "jsaurez@gmail.com",
                    Role = Role.User,
                    PasswordHash = "passwordhash1234"
                };
                var bill = new User
                {
                    Title = "Psychologist",
                    FirstName = "Bill",
                    LastName = "Stewart",
                    Email = "bstewart@gmail.com",
                    Role = Role.User,
                    PasswordHash = "passwordhash1234"

                };
                var mary = new User
                {
                    Title = "Teacher",
                    FirstName = "Mary",
                    LastName = "Smith",
                    Email="msmith@gmail.com",
                    Role=Role.User,
                    PasswordHash="passwordhash1234"
                };
                var john = new User
                {
                    Title = "Manager",
                    FirstName = "John",
                    LastName = "Morris",
                    Email="jmorris@yahoo.com",
                    Role=Role.User,
                    PasswordHash="passwordhash1234"
                };
                    var jane = new User
                {
                    Title = "Student",
                    FirstName = "Jane",
                    LastName = "Dougherty",
                    Email="jdougherty@centercityschool.edu",
                    Role=Role.User,
                    PasswordHash="passwordhash1234"
                };

            var closetitems = new ClosetItem[]
            {
                new ClosetItem
                {
                    User = jackie,
                    Name= "Floral cap-sleeved blouseM",
                    Description= "Small, Spring, Top M",
                    Size= Size.Small,
                    Season= Season.Spring,
                    Type=ClosetItemType.Top
                 },
                new ClosetItem
                {
                    User = jackie,
                    Name= "Corduroy skirt",
                    Description= "Small, Summer, Bottom M",
                    Size= Size.Small,
                    Season= Season.Summer,
                    Type= ClosetItemType.Bottom
                 },
                new ClosetItem
                {
                    User = jackie,
                    Name= "Red long dress",
                    Description= "Medium, Winter, Dress M",
                    Size= Size.Medium,
                    Season= Season.Winter,
                    Type= ClosetItemType.Dress
                  },
                new ClosetItem
                {
                    User = jackie,
                    Name= "London Fog rain coat",
                    Description= "Large, Always, Outerwear M",
                    Size= Size.Large,
                    Season= Season.All,
                    Type= ClosetItemType.Outerwear,
                  },
                new ClosetItem
                {
                    User = jackie,
                    Name= "Black leather boots",
                    Description= "Small, Winter, Footwear M",
                    Size= Size.Small,
                    Season= Season.Winter,
                    Type= ClosetItemType.Footwear,
                 },
                new ClosetItem
                {
                    User = jackie,
                    Name= "White dressy blouse",
                    Description= "Medium, Spring, Top M",
                    Size= Size.Medium,
                    Season= Season.Spring,
                    Type= ClosetItemType.Top,
                },
                new ClosetItem
                {
                    User = jackie,
                    Name= "Blue Corduroy Skirt",
                    Description= "Large, Summer, Bottom M",
                    Size= Size.Large,
                    Season= Season.Summer,
                    Type= ClosetItemType.Bottom,
                },
                new ClosetItem
                {
                    User = jane,
                    Name= "Long Green dress",
                    Description= "Small, Fall, Dress M",
                    Size= Size.Small,
                    Season= Season.Fall,
                    Type= ClosetItemType.Dress,
                },
                new ClosetItem
                {
                    User = jane,
                    Name= "White Sweater",
                    Description= "Medium, Always, Outerwear M",
                    Size= Size.Medium,
                    Season= Season.All,
                    Type= ClosetItemType.Outerwear,
                  },
                new ClosetItem
                {
                    User = jane,
                    Name= "White Blouse",
                    Description= "Medium, Always, Top M",
                    Size= Size.Medium,
                    Season= Season.All,
                    Type= ClosetItemType.Top,
                },
                new ClosetItem
                {
                    User = jane,
                    Name= "Pearl Necklace",
                    Description= "Medium, Winter, Accessory M",
                    Size= Size.Medium,
                    Season= Season.Winter,
                    Type= ClosetItemType.Accessory
                },
                new ClosetItem
                {
                    User = jackie,
                    Name= "Purse",
                    Description= "Large, Spring, Accessory M",
                    Size= Size.Large,
                    Season= Season.Spring,
                    Type= ClosetItemType.Accessory
                },
                new ClosetItem
                {
                    User = jane,
                    Name= "Jeans",
                    Description= "Small, Winter, Bottom M",
                    Size= Size.Small,
                    Season= Season.Winter,
                    Type= ClosetItemType.Bottom
                }
            };

            foreach (ClosetItem ci in closetitems)
            {
                context.ClosetItems.Add(ci);
            }
            context.SaveChanges();
        }
    }
}