namespace Week2Hw2Q2;
class Program
{
    static void Main(string[] args)
    {
          Console.WriteLine("Please input the first num: ");
        string num1 = Console.ReadLine();
        int num1_int = Convert.ToInt16(num1);

        Console.WriteLine("Please input the secone num: ");
        string num2 = Console.ReadLine();
        int num2_int = Convert.ToInt16(num2);

        Console.WriteLine("Please input the third num: ");
        string num3 = Console.ReadLine();
        int num3_int = Convert.ToInt16(num3);

        if(num1_int<num2_int)
      {
        if(num1_int<num3_int)
        {
            Console.WriteLine($"The smallest value is: {num1}");
        }
        else
        {
            Console.WriteLine($"The Smallest value is: {num3}");
        }
      }
        else
        {
         if(num2_int<num3_int)
            {
                Console.WriteLine($"The Smallest value is: {num2}");
            }
         else
         {
            Console.WriteLine($"The Smallest value is: {num3}");
         }  
        }   
    }
}