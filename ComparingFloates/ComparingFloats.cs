﻿using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        Console.Write("");
        double a = double.Parse(Console.ReadLine());
        Console.Write("");
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;


        if (a > b) 

        {
            if (a - b > eps) 
            {
                Console.WriteLine("false");                
            }                        
              else   
            {
                Console.WriteLine("true");
            }
        }

        else if (b > a)

        {
            if ((b - a) > eps) 

            {
                Console.WriteLine("false");
            }   
                     
              else   
            {
                Console.WriteLine("true");
            }

        }

     }
    
}

