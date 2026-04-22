namespace bt2
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(" Bài tập 2: Hoán đổi giá trị");
            int a = 10, b = 20;
            Console.WriteLine("Trước khi đổi: a = {0}, b={1}", a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Sau khi đổi: a = {0}, b={1}", a, b);

            Console.ReadLine();
        }

    }
}