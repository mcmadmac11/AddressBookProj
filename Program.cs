using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			ContactList ct = new ContactList("Dan", 1232322);
			 
			Console.WriteLine("yay {0}", ct.PhoneNumber.ToString());

	// ToDo: [Add writeLines to a display class]  [capture user input to use as arguments in Main]

			
			Console.WriteLine("Welcome to AddressBook! \nEnter the Corresponding Number to make a Selection.\n");
			Console.WriteLine("\n[1]-----Add New Contact");
			Console.WriteLine("\n[2]-----Find Contact");
			Console.WriteLine("\n[3]-----Delete Contact");
			Console.WriteLine("\n[4]-----Exit Program");
			


		}


	}
}
