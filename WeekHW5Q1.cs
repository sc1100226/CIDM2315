namespace Week5Homework5Q1;
class Program
{
    static void Main(string[] args)
    {
      Console.Write("Enter a number for 'a': ");
      int num1 = Convert.ToInt16(Console.ReadLine());
      Console.Write("Enter a number for 'b': ");
      int num2 = Convert.ToInt16(Console.ReadLine());
      
      Console.WriteLine(" ");
    
      Console.WriteLine($"a = {num1}; b={num2}");

      int numbers = greaternum(num1,num2);
      Console.WriteLine($"The largest number is: {numbers} ");
    }
  
   public static int greaternum(int num1, int num2)
    {
       if (num1 > num2)
         return num1;
      else
         return num2;  
    }
}

