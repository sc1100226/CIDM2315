namespace Week8Homework7Q1;
class MainClass
{
    
      public static void Main(string[] args) 
       {
        Console.WriteLine(" "); 
        Customer c1 = new Customer();
        c1.SetCUS(110);
        c1.cus_name = "Alice";
        c1.cus_age = 28;
        c1.PrintCusInfo();
        c1.ChangeID(220);
    
        Customer c2 = new Customer();
        c2.SetCUS(111);
        c2.cus_name = "Bob";
        c2.cus_age = 30;
        c2.PrintCusInfo();
        c2.ChangeID(221);

        c1.PrintCusInfo();
        c2.PrintCusInfo();
    
        if(c1.cus_age > c2.cus_age){
            
            Console.WriteLine("Alice is older");
            Console.WriteLine(" ");
            }
        else{
          
          Console.WriteLine("Bob is older");
          Console.WriteLine(" ");
         }
        }
      
      
        
        class Customer
        {
             public string? cus_name = null;
             public int cus_age;

             public void PrintCusInfo()
            {
                
                Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");

            }
  
            private int cus_id;
            public void SetCUS(int newCUS)
            {
                 cus_id = newCUS;
            }
             public int CheckCUS()
            {
                 return cus_id;
            }
            public void ChangeID(int new_id)
            {
                cus_id = new_id;
            }
   
        }
      
}
    

