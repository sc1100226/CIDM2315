namespace WeekHomework5Q3;
class Program
{
    static void Main(string[] args)
    {
       creatAccount ();
    
    }

  public static void creatAccount()
  {
    string username;
    string password;
    string passwordAgain;
    int age;

    Console.WriteLine("Enter your Username");
    username = Console.ReadLine();
    Console.WriteLine("Enter your Password");
    password = Console.ReadLine();
    Console.WriteLine("Enter your Password Again");
    passwordAgain = Console.ReadLine();
    Console.WriteLine("Enter your Birthyear");
    int birthyear = Convert.ToInt32(Console.ReadLine());

    age = 2022 - birthyear;

    bool birth_year = age >=18;

    if (birth_year == true && password == passwordAgain)
      Console.WriteLine("Account created sucessfully!!");
      else
        if (birth_year == true && password != passwordAgain)
          Console.WriteLine("Wrong password");
    else
      Console.WriteLine("Could not create an account.");      

  } 
    
}
