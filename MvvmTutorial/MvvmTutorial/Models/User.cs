using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input.Manipulations;

namespace MvvmTutorial.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public User(string firstName, string lastName, DateTime dob)
            => (FirstName, LastName, DateOfBirth) = (firstName, lastName, dob);
    }
}
