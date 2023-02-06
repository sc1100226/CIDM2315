namespace week3homework3Q1;
class Program
{
    static void Main(string[] args)
    {
        int i, a;
        Console.WriteLine("Input an integer:");
        string num = Console.ReadLine();
        int num_int = Convert.ToInt32(num);
        a = 0;
        i = 2;
        while (i <= num_int / 2)
        {
            if(num_int % i == 0)
        {
            a = 1;
        break;
        }
        i++;
        }
  
        {
        if (a == 0)
         Console.WriteLine($"{num} is a prime");
        else
          Console.WriteLine($"{num} is non-prime");  

        }
    }
}