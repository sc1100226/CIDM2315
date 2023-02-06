namespace week3Homework3Bonus;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N: ");
        string n = Console.ReadLine();
        int n_int = Convert.ToInt16(n);
    
        for(int row = 1; row <= n_int; row++)
        {
            for(int col = n_int; col >= 1; col--)
            {
                if(row < col)
                Console.Write(" ");
            else  
                Console.Write(row);
            }
            Console.WriteLine();  
        }
    }
}
