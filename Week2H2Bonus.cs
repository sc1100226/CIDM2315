namespace Week2HW2Bonus;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a year to determine if its a leap year: ");
        string year = Console.ReadLine();
        int year_int = Convert.ToInt16(year);
        if ((year_int % 400) == 0)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else if ((year_int % 100) == 0)
        {
        Console.WriteLine($"{year} is not a leap year."); 
        }
        else if ((year_int % 4) == 0)
        {
        Console.WriteLine($"Yes, {year} is a leap year.");
        }
        else
        {
        Console.WriteLine($"No, {year} is not a leap year.");
        }   
    }
}