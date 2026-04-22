using System.Text;

namespace bt7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 7: In mã ASCII");
            char kyTu = 'L';
            int acsii = (int)kyTu;
            Console.WriteLine("Mã ASCII của ký tự '{0}' là: {1}", kyTu, acsii);

            Console.ReadLine();
        }
    }
}