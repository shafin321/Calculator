// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine("Enter: Add->1, Minus-2, Multipy->3, Division ->4 ");
        int input= int.Parse(Console.ReadLine());

        do
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter number");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number");
                    int n2 = int.Parse(Console.ReadLine());
                    add(n1, n2);

                    break;

                case 2:

                    Console.WriteLine("Enter number");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number");
                    int x2 = int.Parse(Console.ReadLine());
                    minus(x1,x2);

                    break;

                case 3:
                    Console.WriteLine("Enter number");
                    int m1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number");
                    int m2 = int.Parse(Console.ReadLine());
                    multipy(m1, m2);
                    break;

                case 4:
                    Console.WriteLine("Enter number");
                    int d1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number");
                    int d2 = int.Parse(Console.ReadLine());
                    Devide(d1, d2);
                    break;

            }
            Console.WriteLine("You want to continue ->yes/no?");
           
        } while (Console.ReadLine()!="no");

    }

    public static void add(int x, int y)
    {
        Console.WriteLine($" res: {x+y}");
    }

    public static void minus(int x, int y)
    {
        Console.WriteLine($" res: {x - y}");
    }

    public static void multipy(int x, int y)
    {
        Console.WriteLine($" res: {x * y}");
    }

    public static void Devide(int x, int y)
    {
        Console.WriteLine($" res: {x / y}");
    }
}

