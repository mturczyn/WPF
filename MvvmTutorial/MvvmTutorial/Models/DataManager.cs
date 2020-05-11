using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MvvmTutorial.Models
{
    public class DataManager
    {
        private string _fieldSeparator = ",";
        private const string _pathToDataFile = @"../../../Models/users.txt";
        private List<User> _users;
        public DataManager() 
        { }
        public List<User> Users
        {
            get => _users ?? (_users = GetUsers());
            set { _users = value; }
        }

        private List<User> GetUsers()
        {
            var users = File.ReadAllLines(_pathToDataFile)
                .Select(u => u.Split(_fieldSeparator))
                .Select(spl => new User(spl[0], spl[1], DateTime.Parse(spl[2])))
                .ToList();
            return users;
        }

        public void SaveUsers()
        {
            File.WriteAllLines(_pathToDataFile,Users.Select(user => string.Join(_fieldSeparator, new string[] { user.FirstName, user.LastName, user.DateOfBirth.ToString("dd-MM-yyyy") })));
        }


    }
}
