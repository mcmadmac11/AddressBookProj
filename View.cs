using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class View
    {
        public View(ContactList contactList)
        {

            Dictionary<string, uint> Contacts = new Dictionary<string, uint>();
            Contacts.Equals(contactList);


        }


    }
    
}
