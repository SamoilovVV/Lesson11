using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Presenters;
using WinFormsApp.Views;

namespace WinFormsApp
{
    public partial class PersonForm : Form, IPersonView
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        public string PersonName
        {
            get => tbName.Text;
            set => tbName.Text = value;
        }
        public string Age
        {
            get => tbAge.Text;
            set => tbAge.Text = value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
