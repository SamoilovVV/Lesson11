using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Views
{
    public interface IPersonView
    {
        string PersonName { get; set; }

        string Age { get; set; }
    }
}
