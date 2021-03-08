using System;

namespace demo
{
    class Net   // Lớp net mặc định kế thừa từ lớp object do s# cung cấp nên có 3 hàm cần override là ToString(), GetHashCode(), Equals()
    {
        public int MASV {get;set;}
        // tạo ra một thuộc tính là MASV ở private
        // và tạo ra thêm 1 property có tên trùng với thuộc tính  
        //property chức năng thay thế cho 1 căp get set ví dụ sv1.MASV = sv2.MASV thì sẽ tự động gán set của sv1 = get của sv2 
        // 1 property thông thường có dạng như sau 
        // public int MASV 
        //{
        // get {return MASV}; set {MASV  = value;}
        //}
        public void show()
        {
           Console.WriteLine("MASV = {0}", MASV);
        }
        public override string ToString()
        {
            return "MASV = "+ MASV;
        }
    }
    class Program
    {
        static void A(out int x)
        {
            x=6;
        }
        static void try1 (ref int a,ref int b)
        {
            int x=a;
            a=b;b=x;
        }
        static int Sum(params int[] b)// params tự động chuyển {1,2,3,4} thành 1 mảng 
        {   
            int Tong=0;
            for(int i=0;i<b.Length;i++)
            {
                Tong +=b[i];
            }
            return Tong;
        }
        static void Main(String[] args)
        {
            int m;
            // m = Convert.ToInt32(Console.ReadLine());
            // n=Convert.ToInt32(Console.ReadLine());
            // try1(ref m, ref n);
            // Console.WriteLine("M = {0} , N={1}",m,n);
            // int z;
            // A(out z);
            // Console.WriteLine(z);//boxing unboxing
            m = Convert.ToInt32(Console.ReadLine());
            string []arr = new string [m];
            // for (int i =0;i<m;i++)
            // {
            //     arr[i]=Convert.ToString(Console.ReadLine());
            // }
            // for (int i =0;i<m;i++)
            // {
            //     Console.Write("{0} ",arr[i]);
            // }
            // foreach(string i in arr)//foreach chi chay toi phan tu rong // foreach khong the dung i de thay doi phan tu cura mang
            // {                       //foreach có thể dùng để thay đổi mảng các đối tượng vì i có thể trỏ tới thành phần phương thức của đối tượng đó.
            //     Console.Write(i);
            // }


            // int [,] xx= new int [2,3];
            // for(int i=0;i<2;i++)
            // {
            //     for(int a=0;a<3;a++)
            //     {
            //        xx[i,a]= Convert.ToInt32(Console.ReadLine());
            //     }
            // }
            // foreach(int b in xx)
            // {
            //     // foreach(int y in b)
            //     {
            //         Console.Write(b+" ");
            //     }
            // }


            string[][] softwares = new string [3][];
            softwares[0]=new string[]{"Blitz","Hello","Anno","nhac"};
            softwares[1]=new string []{"Tuan","anh"};
            softwares[2]=new string[] {"Nguoi","ngoai","hanh","tinh"};
            for(int i=0;i<3;i++)
            {
                Console.WriteLine();
                for (int j=0;j<softwares[i].GetLength(0);j++)
                {
                    Console.Write(softwares[i][j]+" ");
                }
            }
            foreach(string[] arr1 in softwares)
            {
                Console.WriteLine();
                foreach(string arr2 in arr1)
                {
                    Console.Write(arr2+" ");
                }
            }
            int cc=Sum(1,2,3,4);
            Console.Write(cc);

            // cách khai báo thuộc tính hiện nay hay dùng
            Net sv1 = new Net{
                MASV =1 // mỗi thuộc tính cách nhau bởi dấu phẩy ","
            };//đây là cách tạo thộc tính thông qua property dễ dàng hơn nhiều 
            sv1.show();
        }
    }
}
