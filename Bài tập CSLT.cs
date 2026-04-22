using System.Text;

namespace bt10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 10: Đổi số ngày ");
            int totalDays = 800;
            int years = totalDays / 365;
            int weeks = (totalDays % 365) / 7;
            int days = (totalDays % 365) % 7;

            Console.WriteLine("Số ngày {0} tương ứng với {1} năm, {2} tuần và {3} ngày.", totalDays, years, weeks, days);

            Console.ReadLine();
        }
    }
}