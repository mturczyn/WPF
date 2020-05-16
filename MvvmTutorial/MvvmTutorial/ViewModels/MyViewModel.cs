using MvvmTutorial.Commands;
using MvvmTutorial.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MvvmTutorial.ViewModels
{
    public class MyViewModel
    {
        private static string[] _firstNames = { "Michał", "Marek", "Antoni", "Zosia", "Paulina", "Anna", "Tomasz", "Radosław", "Bartosz", "Grzegorz", "Lucyna", "Katarzyna", "Barbara" };
        private static string[] _lastNames = { "Kowal", "Nowak", "Kawon", "Lakow", "Smolarek", "Piechniczek", "Adams" };
        private static Random rnd = new Random();
        private string RandomFirstName => _firstNames[rnd.Next(_firstNames.Length)];
        private string RandomLastName => _lastNames[rnd.Next(_lastNames.Length)];

        private DataManager _dataManager;

        private ICommand _addRandomNewUser;
        private ICommand _removeUser;
        private ICommand _saveChanges;

        public MyViewModel(DataManager dataManager)
        {
            _dataManager = dataManager;
            Users = new ObservableCollection<User>(_dataManager.Users);
        }

        public ObservableCollection<User> Users { get; set; }
        public User ChosenUser { get; set; }
        public ICommand AddRandomNewUser => _addRandomNewUser ?? (_addRandomNewUser = new ActionCommand(() =>
        {
            var date = new DateTime(
               rnd.Next(1950, 2020),
               rnd.Next(1, 13),
               rnd.Next(1, 31));
            var user = new User(RandomFirstName, RandomLastName, date);
            _dataManager.Users.Add(user);
            _dataManager.SaveUsers();
            Users.Add(user);
        }));
        public ICommand RemoveUser => _removeUser ?? (_removeUser = new ActionCommand(() =>
        {
            if (ChosenUser == null) return;
            _dataManager.Users.Remove(ChosenUser);
            _dataManager.SaveUsers();
            Users.Remove(ChosenUser);
        }));
        public ICommand SaveChagnes => _saveChanges ?? (_saveChanges = new ActionCommand(() =>
        {
            _dataManager.SaveUsers();
        }));
    }
}
