namespace Week4Homeowrk4Q1;
class Program
{
    static void Main(string[] args)
    {
       int a = 3;
        int b = 5;
         int numbers = greaternum(a,b);

        Console.WriteLine($"a = {a}; b={b}");
        Console.WriteLine($"The largest number is: {numbers} ");


    }
    public static int greaternum(int a, int b){
      if (a > b)
        return a;
      else
        return b; 
    }
}
