namespace bt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Bài tập 3: Nhân 2 số thập phân");
            double a = 10.5, b = 20.3;
            double tich = a * b;
            Console.WriteLine("Tích của {0} và {1} là: {2}", a, b, tich);

            Console.ReadLine();

        }
    }
}