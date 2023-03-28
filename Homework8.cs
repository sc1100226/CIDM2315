namespace Week10Homework8;
class Program
{
    public static void ArraySum(int[] int_array)
    {
        
        int sum = 0;
        for (int i = 0; i < int_array.Length; i++)
        {
            sum += int_array[i];
        }

        Console.WriteLine("The sum of int_array is: " + sum);
    }

    public static void Main(string[] args)
    {
        int[] int_array = {11, 23, 31, 42, 53};
        ArraySum(int_array);


       //Q2.1
        int[,] array2D = new int[3,3] {{1,2,3}, {4,5,6}, {7, 8, 9}};
        printAllOddNumber(array2D);
            
        //Q2.2
        int sum = ElementSum(array2D);
        Console.WriteLine(" ");
        Console.WriteLine("The Sum of 2d array: " + sum); 
            

        // Q2.3
        int[ , ] res = DoubleArray(array2D);
        Console.WriteLine("The new 2d Array: "); 
        int n =  res.GetLength(0);
        int m =  res.GetLength(0);
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
              Console.Write(res[i,j]+ " ");
            }
        }
        
    }
    
    public static void printAllOddNumber(int[,] array_2d) {
        
        
        int n =  array_2d.GetLength(0);
        int m =  array_2d.GetLength(0);
        
        Console.WriteLine(""); 
        
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
                
                if(array_2d[i,j] % 2 == 1) {
                  Console.Write(array_2d[i, j] + " ");  
                }
            }
        }
    }
    
    public static int ElementSum(int[,] array_2d) {
        
        int n =  array_2d.GetLength(0);
        int m =  array_2d.GetLength(0);
            
        
        int sum = 0;
        
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
              sum += array_2d[i, j];  
            }
        }
        
        return sum;
    }
    
    public static int[,] DoubleArray(int[,] array_2d) {
        
        int n =  array_2d.GetLength(0);
        int m =  array_2d.GetLength(0);
        
        
        int[,] res = new int[n, m];
        
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
              res[i,j] = 2 * array_2d[i, j];  
            }
        }
            
        
        return res;
    } 
}
