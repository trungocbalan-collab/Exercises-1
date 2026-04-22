namespace bt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Bài tập 4: Đổi Feet sang mét ");
            double feet = 10;
            double met = feet * 0.3048;
            Console.WriteLine("Đổi {0} feet sang mét là: {1} mét", feet, met);

            Console.ReadLine();
        }

    }
}


