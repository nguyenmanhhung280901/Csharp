using System;
using System.Text;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string ten, diachi;
            int sodienthoai;
            Console.WriteLine("Xin chào, mời bạn nhập thông tin cá nhân");
            Console.Write("Họ tên của bạn là: ");
            ten = Console.ReadLine();
            Console.Write("Địa chỉ của bạn là: ");
            diachi = Console.ReadLine();
            Console.Write("Số điện thoại của bạn là:");
            sodienthoai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Thông tin của bạn là: \n");
            Console.WriteLine("Tên của bạn: \n" + String.Format(ten));
            Console.WriteLine("Địa chỉ của bạn: \n" + String.Format(diachi));
            Console.WriteLine("Số điện thoại của bạn: \n" + sodienthoai);
            Console.Read(); 
        }
    }
}