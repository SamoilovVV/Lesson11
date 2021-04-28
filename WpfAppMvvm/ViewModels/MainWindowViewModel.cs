using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppMvvm.Models;
using WpfAppMvvm.Views;

namespace WpfAppMvvm.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<Person> _persons = new ObservableCollection<Person>
        {
                new Person
                {
                    Name = "Вася",
                    Age=25
                },
                new Person
                {
                    Name = "Петя",
                    Age=32
                }
        };

        public ObservableCollection<Person> Persons
        {
            get => _persons;
            set => Set(ref _persons, value);
        }

        public ICommand AddPersonCommand { get; private set; }
        public MainWindowViewModel()
        {
            AddPersonCommand = new RelayCommand(OnPersonAdd, CanPersonAdd);
        }

        private bool CanPersonAdd(object arg)
        {
            return true;
        }

        private void OnPersonAdd(object obj)
        {
            PersonViewModel vm = new PersonViewModel();
            PersonView personView = new PersonView
            {
                DataContext = vm
            };
            
            if (personView.ShowDialog() == true)
            {
                Persons.Add(vm.Person);
            }
        }
    }
}
