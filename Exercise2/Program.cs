using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Tìm số lớn nhất trong 3 số
            int num1, num2, num3;
            Console.Write("Nhập số thứ nhất: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số thứ 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số thứ 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Số thứ nhất là số lớn nhất trong 3 số. \n");
                }
                else
                {
                    Console.Write("Số thứ ba là số lớn nhất trong 3 số. \n");
                }
            }
            else if (num2 > num3)
                Console.Write("Số thứ hai là số lớn nhất trong 3 số.\n");
            else
                Console.Write("Số thứ ba là số lớn nhất trong 3 số. \n");

            Console.ReadKey();
        }
    }
}