using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Models;
using WinFormsApp.Views;

namespace WinFormsApp.Presenters
{
    public class PersonPresenter
    {
        private IPersonView _personView;

        public Person Person { get; }
        public PersonPresenter()
        {
            Person = new Person();
            var form = new PersonForm();
            form.FormClosed += OnFormClosed;
            _personView = form;
        }

        private void OnFormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            var form = sender as Form;
            if (form.DialogResult != DialogResult.OK)
            {
                return;
            }

            Person.Name = _personView.PersonName;
            Person.Age = int.TryParse(_personView.Age, out int val) ? val : 0;
        }

        public bool Show()
        {
            _personView.PersonName = Person.Name;
            _personView.Age = Person.Age.ToString();

            DialogResult res = (_personView as PersonForm).ShowDialog();
            
            if (res == DialogResult.OK)
            {
                Person.Name = _personView.PersonName;
                Person.Age = int.TryParse(_personView.Age, out int val) 
                    ? (val < 0 ? 0 : val)
                    : 0;
                return true;
            }

            return false;
        }
    }
}
