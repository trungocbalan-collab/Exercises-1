using System.Text;

namespace bt8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 8: Tính diện tích hình tròn");
            double banKinh = 5.0;
            double dienTich = 3.14 * banKinh * banKinh;
            Console.WriteLine("Diện tích của hình tròn có bán kính {0} là: {1}", banKinh, dienTich);
            Console.ReadLine();
        }
    }
}