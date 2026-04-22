namespace bt6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 6: Kích thước kiểu dữ liệu ");
            Console.WriteLine("Kiểu int: " + sizeof(int));
            Console.WriteLine("Kiểu double: " + sizeof(double));
            Console.WriteLine("Kiểu char: " + sizeof(char));

            Console.ReadLine();
        }
    }
}