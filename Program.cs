﻿using System;
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

            View view = new View();
            view.display();
            MyDictionary md = new MyDictionary();
            md.myDictionary();
        }
    }
}
