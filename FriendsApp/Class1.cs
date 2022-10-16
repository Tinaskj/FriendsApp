using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsApp
{
    internal class Profile
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public bool Male { get; set; }
        private List<Profile> Friends { get; set; }

        public Profile(string name, string id)
        {
            Name = name;
            Id = id;
            Friends = new List<Profile>();
            
        }

        public void PrintProfileInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Male: {Male}");
            ShowFriends();
        }
        
        public void ShowFriends()
        {
            foreach (var friend in Friends)
            {
                Console.WriteLine($"{friend.Name} {friend.Id}");
            }
        }
        public void AddFriend(Profile friendToAdd)
        {
            Friends.Add(friendToAdd);
        }
        public void RemoveFriend(Profile friendToRemove)
        {
            Friends.Remove(friendToRemove);
        }
    }
}
