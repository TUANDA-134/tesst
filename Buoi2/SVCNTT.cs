using System;

namespace Buoi2
{
    class SVCNTT : SV
    {
        public bool skill {get; set;}
        public SVCNTT(int m, string n,double l,bool t)
        :base(m,n,l)
        {
            skill=t;
        }
        public void show()
        {
            base.show();
            Console.WriteLine("Skill {0}",skill);
        }
    }
}