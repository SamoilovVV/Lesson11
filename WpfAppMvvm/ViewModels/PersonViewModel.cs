using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMvvm.Models;

namespace WpfAppMvvm.ViewModels
{
    public class PersonViewModel : BaseViewModel
    {
        public Person Person { get; }

        public string Name
        {
            get => Person.Name;
            set
            {
                if (value != Person.Name)
                {
                    Person.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public int Age
        {
            get => Person.Age;
            set
            {
                if (value != Person.Age)
                {
                    Person.Age = value;
                    OnPropertyChanged(nameof(Age));
                }
            }
        }

        public PersonViewModel()
        {
            Person = new Person();
        }
    }
}
