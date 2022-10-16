using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsApp
{
    class SocialNetwork
    {
        private List<Profile> ListOfUsers { get; set; }
        private Profile loggedInProfile;
        public SocialNetwork()
        {
            loggedInProfile = new Profile("Davina", "0");

            ListOfUsers = new List<Profile>();
            ListOfUsers.Add(new Profile("Jamie", "1"));
            ListOfUsers.Add(new Profile("Rose", "2"));
            ListOfUsers.Add(new Profile("Lucy", "3"));
            ListOfUsers.Add(new Profile("Lucifer", "4"));

            while (true)
            {
                PrintMenu();
                var userInput = Console.ReadLine();
                HandleMenuOption(userInput);
            }
           
        }

        private void ShowUsers()
        {
            foreach (var user in ListOfUsers)
            {
                Console.WriteLine($"{user.Name} { user.Id}");
            }
        }
        private void PrintMenu()
        {
            Console.WriteLine("Welcome to Friendface");
            Console.WriteLine("1. Add friend");
            Console.WriteLine("2. Remove friend");
            Console.WriteLine("3. Print friends");
            Console.WriteLine("4. Show friend info");
        }

        private void HandleMenuOption(string menuOption)
        {
            if(menuOption == "1")
            {
                Console.WriteLine("MenuOption 1: Add friend: ");
                ShowUsers();
                Console.WriteLine("Choose the id of the user you want to add");
                var chosenUserId = Console.ReadLine();
                var userProfile = GetUserProfile(chosenUserId);
                loggedInProfile.AddFriend(userProfile);
            }
            if(menuOption == "2")
            {
                loggedInProfile.ShowFriends();
                Console.WriteLine("Choose which friend to remove: ");
                var friendId = Console.ReadLine();
                var profileToRemove = GetUserProfile(friendId);
                loggedInProfile.RemoveFriend(profileToRemove);
            }
            if(menuOption == "3")
            {
                loggedInProfile.ShowFriends();
            }
            if(menuOption == "4")
            {
                loggedInProfile.ShowFriends();
                var friendId = Console.ReadLine();
                var profile = GetUserProfile(friendId);
                profile.PrintProfileInfo();
            }
        }
        private Profile GetUserProfile(string id)
        {
            return ListOfUsers.FirstOrDefault(user => user.Id == id);
        }
    }
}
