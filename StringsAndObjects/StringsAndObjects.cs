﻿using System;
//Declare two string variables and assign them with Hello and World.Declare an object variable and assign it with the concatenation of the first two variables(mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable(you should perform type casting).

namespace StringsAndObjects
{
class StringsAndObjects
{
    static void Main()
    {
       string a = "hello";
       string b = "world";
            object c = a + " " + b;
            string d = (string)c;
            Console.WriteLine(a b);
            Console.WriteLine(c);
            Console.WriteLine(d);


        }
}
}
