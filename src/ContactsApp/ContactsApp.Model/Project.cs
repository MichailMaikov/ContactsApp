using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Project
    {
        private List<Contact> _contacts = new List<Contact>();
        public List<Contact> Contacts { get; set; }
    }
}
