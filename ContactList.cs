using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
	class ContactList
	{
		public string Name;
		public uint PhoneNumber;
		public ContactList(string name, uint phoneNumber)
		{
			this.Name = name;
			this.PhoneNumber = phoneNumber;
		}
		
	}
}
