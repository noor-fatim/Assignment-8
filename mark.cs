using System;
namespace Assignment_8
{
    public class mark
    
        {
          public float Sub_1;
    public float Sub_2;
    public float Sub_3;
    public  void Sum()
    {
        float sum = Sub_1 + Sub_2 + Sub_3;
        Console.WriteLine("Sum of Subjects is  =  " + sum);
    }
     public  void Average()
    {
        float avg =( Sub_1 + Sub_2 + Sub_3)/3;
        Console.WriteLine("Average of Subjects is  =  " + avg);
    }  
        }
    }
