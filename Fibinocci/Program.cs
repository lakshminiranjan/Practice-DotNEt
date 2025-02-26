/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
    public int Fib(int n){
        // int a,b,c,n,i;
        // Console.WriteLine("Enter the number: ");
        // n = Convert.ToInt32(Console.ReadLine());
        
        // a = 0;
        // b = 1;
        // Console.WriteLine(a + "\n" + b);
        
        // for(i = 1; i <= n; i++)
        // {
        //     c = a + b;
        //     a = b;
        //     b = c;
        //     Console.WriteLine(c);
        // }
        int a = 0,b = 1;
        if(n <= 0)
            return -1;
        else if(n == 1)
            return 0;
        else if(n == 2)
            return 1;

        Console.WriteLine(a + "\n" + b);
        for(int i= 2;i <= n; i++)
        {
            int c = a+b;
            a = b;
            b = c;
            Console.WriteLine(c);
        }
        
        return b;
    }
  static void Main(String[] args) {
    // HelloWorld obj = new HelloWorld();
    // obj.Fib();
    HelloWorld obj = new HelloWorld();
    Console.WriteLine("Enter the number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int i = obj.Fib(n);
    Console.WriteLine("The " + n + " th fibbinoci number is " + i);
  }
}
