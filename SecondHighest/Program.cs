using System;

class Program
{
         //int
    public void SecHighest()
    {
        int max1, max2;
        int[] a = {1,2,3,4};
        if(a[0] > a[1])
        {
            max1 = a[0];
            max2 = a[1];
        }
        else
        {
            max1 = a[1];
            max2 = a[0];
        }
        for(int i = 2; i < a.Length; i++)
        {
            if(a[i] > max1)
            {
                max2 = max1;  // Store the old maximum as second highest
                max1 = a[i];  // Update the maximum
            }
            else if(a[i] > max2)
            {
                max2 = a[i];
            }
        }
        // return max2;
        Console.WriteLine(max2.ToString());
    }
    static void Main(string[] args)
    {
        Program obj = new Program();
        obj.SecHighest();
        // int i = obj.SecHighest();
        // Console.WriteLine(i.ToString());
    }
}



//another solution.

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public void Seconghigh(){
        int max1=0,max2=0;
        int[] a = {2,4,35,4,3,22,3,33,45,5};
        for(int i = 0; i < a.Length; i++)
        {
            if(a[i] > max1)
            {
                max2 = max1;  // Store the old maximum as second highest
                max1 = a[i];  // Update the maximum
            }
            else if(a[i] > max2)
            {
                max2 = a[i];
            }
        }
        Console.WriteLine(max2.ToString());
    }
    
    
    public static void Main(string[] args)
    {
        HelloWorld obj = new HelloWorld();
        obj.Seconghigh();
    }
}
