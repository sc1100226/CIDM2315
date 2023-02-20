namespace Week5Homework5Q2;
class Program
{
    static void Main(string[] args)
    {
      Console.Write("Enter a number for 'a': ");
      int num1 = Convert.ToInt16(Console.ReadLine());
      Console.Write("Enter a number for 'b': ");
      int num2 = Convert.ToInt16(Console.ReadLine());
      Console.Write("Enter a number for 'c': ");
      int num3 = Convert.ToInt16(Console.ReadLine());
      Console.Write("Enter a number for 'd': ");
      int num4 = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine(" ");
    
      Console.WriteLine($"a = {num1}; b={num2}; c = {num3}; d={num4};");

      int numbers = greaternum(num1,num2,num3,num4);
      Console.WriteLine($"The largest number is: {numbers} ");
    }
  
   public static int greaternum(int num1, int num2, int num3, int num4)
   {
       if (num1 > num2 && num1 > num3 && num1 > num4)
          return num1;
       if (num2 > num3 && num2 > num4)
          return num2;
       if (num3 > num4)
          return num3;
          return num4;   
   }  
    
}

