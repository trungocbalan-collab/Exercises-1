using System.Text;

namespace b9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 9:Diện tích hình vuông ");

            double canh = 4.0;
            double dienTich = canh * canh;
            Console.WriteLine("Diện tích của hình vuông có cạnh {0} là: {1}", canh, dienTich);
            Console.ReadLine();
        }
    }

}
