using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demoapplication
{
    public class newClass
    {
        public string TestProperty { get; set; }
        public newClass()
        {
            Console.Write("a new class");
            TestProperty = "Teststring";
        }
    }
}