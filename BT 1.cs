using System;
using System.Text;

namespace bt1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Bài tập 1: Tính tổng");
            int a = 10, b = 20;
            int tinhTong = a + b;
            Console.WriteLine("tổng của {0} và {1} là: {2}", a, b, tinhTong);

            Console.ReadLine();

        }
    }
}