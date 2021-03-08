using System;

namespace Buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SV s1= new SV()
            {
                MASV = 1,
                DTB=2,
                Ten = "Tuan"
            };
            s1.show();
            Console.WriteLine(s1.ToString());
        }
    }
}
