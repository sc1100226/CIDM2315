namespace Week2Homework2;
class Program
{
    static void Main(string[] args)
    {
        string letter = null;
        Console.WriteLine("Please input a letter grade: ");
        letter = Console.ReadLine();
        if (letter == "A")
    {
        Console.WriteLine("GPA point: 4");
    }
        else if (letter == "B")
    {
        Console.WriteLine("GPA point: 3");
    }
        else if (letter == "C")
    {
        Console.WriteLine("GPA point: 2");
    }
        else if (letter == "D")
    {
        Console.WriteLine("GPA point: 1");
    }
        else if (letter == "F")
    {
        Console.WriteLine("GPA point: 0");
    }
        else{
        Console.WriteLine("Wrong Letter Grade!");
        }
    }
}
