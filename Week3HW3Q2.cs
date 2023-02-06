namespace week3homework3Q2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N: ");
        string n = Console.ReadLine();
        int n_int = Convert.ToInt16(n);
        for(int row = 0; row < n_int; row++)
        {
            for(int col = 0; col < n_int; col++)
            {
                Console.Write('#');
            }
            Console.WriteLine("");  
        }
    }
}
