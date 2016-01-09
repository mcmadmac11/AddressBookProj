using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary
    {

        public Dictionary<string,string> myDictionary()
        {
            Dictionary<string, string> addressBook = new Dictionary<string, string>();
            Dictionary<string, string> AddressBook = new Dictionary<string, string>();

            AddressBook.Add("Dan, Sara McManus", "Port Washington");
            AddressBook.Add("Brad, Vicki McManus", "Milwaukee");


            foreach (KeyValuePair<string, string> keyValPair in AddressBook)
            {
                Console.WriteLine(string.Format("Key: {0} ||-->|| {1}", keyValPair.Key, keyValPair.Value));
            }

            AddressBook.Equals(addressBook);
            return addressBook;

            

            
            


        }
        
                
    }
}
