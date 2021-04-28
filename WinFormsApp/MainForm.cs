using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Models;
using WinFormsApp.Presenters;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Person> _persons = new List<Person>
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

        public MainForm()
        {
            InitializeComponent();
            UpdatePersonsListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonPresenter personPresenter = new PersonPresenter();
            if (personPresenter.Show())
            {
                _persons.Add(personPresenter.Person);
                UpdatePersonsListView();
            }
        }

        private void UpdatePersonsListView()
        {
            listPerson.Items.Clear();
            foreach (var person in _persons)
            {
                listPerson.Items.Add(person);
            }
        }
    }
}
