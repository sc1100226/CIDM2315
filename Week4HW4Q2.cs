namespace Week4Homework4Q2;
class Program
{
    
   static void pattern(int N,string shape){
    
    int row,col;
    if(shape == "left"){
    
       for(row = 1;row <= N;row++)
       {
        for(col = 1;col <= row;col++)
           Console.Write("*");
        Console.Write("\n");
       }
      }
    else if(shape=="right"){
    
     for(row = 1; row <= N; row++){
      for(col = N; col >= 1; col--){
        if(row < col)
          Console.Write(" ");
        else  
          Console.Write("*");
        }
      Console.WriteLine();
    }  
        Console.WriteLine();}
    }
    public static void Main() 
{
   int N;
   string shape;
   Console.Write("Enter a number: ");
   N = Convert.ToInt32(Console.ReadLine());
   Console.Write("Enter left or right: ");
   shape = Console.ReadLine();
   Console.WriteLine(" ");
   Console.Write("N is: "+N+"; shape is "+shape+"\n");
   pattern(N,shape);
}    
    
}
