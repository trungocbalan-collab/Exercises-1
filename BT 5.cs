namespace bt5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 5: Đổi độ C sang độ F");
            double C = 20;
            double F = (1.8*C)+ 32;
            Console.WriteLine("Đổi {0} độ C sang độ F là: {1} F  ", C, F);

            Console.ReadLine();
        }
        }
    }