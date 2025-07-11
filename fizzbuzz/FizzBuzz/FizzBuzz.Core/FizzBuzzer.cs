// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Text;


namespace FizzBuzz.Core;
public class FizzBuzzer
{

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string FizzBuzz(int n)
    {
        string fizzBuzz = "FizzBuzz";
            if (n % 3 == 0 && n % 5 == 0) 
        {
            return fizzBuzz;
        }
        if (n % 3 == 0)
        {
            return fizzBuzz.AsSpan(0,4).ToString();
        }
        if (n % 5 == 0)
        {
            return fizzBuzz.AsSpan(4).ToString();
        }
        return n.ToString();
    }
}


