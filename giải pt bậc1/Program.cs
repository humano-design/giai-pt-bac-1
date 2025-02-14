using System.Text;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Nhập vào a: ");
        float a, b, x;
         a = float.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Nhập vào b: ");
             b = float.Parse(Console.ReadLine());

             x = -b / a;
            Console.WriteLine("{0}x + {1} = 0 \n=> x = {2}", a, b, x);
        }
    }
}