using System;

namespace Buoi2
{
    class SV
    {
        public int MASV {get; set;}
        public string Ten{get;set;}
        public double DTB{get; set;}
        public SV()
        {

        }
        public virtual void show()
        {
            Console.WriteLine("MASV = {0}, Ten = {1}, DTB = {2}",MASV,Ten,DTB);
        }
        public override string ToString()
        {
            return "MASV "+MASV+" Ten "+ Ten+" DTB "+DTB;
        }
        public SV(int MASV,String Ten,double DTB)
        {
            this.MASV=MASV;
            this.Ten=Ten;
            this.DTB=DTB;
        }
    }
}