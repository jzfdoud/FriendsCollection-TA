using System;
using System.Collections.Generic;

namespace FriendsCollection_TA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day #9 of C# continuing from friday- List<>, Dictionary<>

            //List<> in class lab
            var friends = new List<Friend>();

            var ken = new Friend { Name = "Ken", Email = "ken@friend.com", BFF = true };
            friends.Add(ken);
            var dad = new Friend { Name = "Greg", Email = "dad@friend.com", BFF = true };
            friends.Add(dad);
            var nancy = new Friend { Name = "Nancy", Email = "nancy@friend.com", BFF = false };
            friends.Add(nancy);

            foreach (var friend in friends)
            {
                Console.WriteLine($"{friend.Name}");
            }

            // Dictiionary<> in class lab- same Friend example

            var friends1 = new Dictionary<long, Friend>();

            var ken1 = new Friend { Name = "Ken", Email = "ken@friend.com", BFF = true, Phone = 5131115555 };
            friends1.Add(ken1.Phone, ken1);
            var dad1 = new Friend { Name = "Greg", Email = "dad@friend.com", BFF = true, Phone = 5132225555 };
            friends1.Add(dad1.Phone, dad1);
            var nancy1 = new Friend { Name = "Nancy", Email = "nancy@friend.com", BFF = false, Phone = 5133335555 };
            friends1.Add(nancy1.Phone, nancy1);

            foreach (var phone in friends1.Keys)
            {
                var friend1 = friends1[phone];
                Console.WriteLine($"{friend1.Name} : {friend1.Phone}");
            }



        }
    }
}
