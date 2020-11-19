namespace _01.strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    class StringsDemo
    {
        static void Main(string[] args)
        {
            string a = "abc";
            string b = "abcd";
           // Console.WriteLine( a < b);
            // <, > operators can not be applied to strings-we can not compare tehm like that
            Console.WriteLine(a == b);
        } 
    }
}
