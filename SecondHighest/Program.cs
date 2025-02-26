using System;

class Program
{
    public void SecHighest()
    {
        int max1, max2;
        int[] a = {78,75,14,84,56,94};
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
        Console.WriteLine(max2.ToString());
    }
    static void Main(string[] args)
    {
        Program obj = new Program();
        obj.SecHighest();
    }
}
