// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

static string FizzBuzz(int n) {
    StringBuilder result = new StringBuilder("",8);
    if (n % 3 == 0)
    {
        result.Append("Fizz");
    }
    if (n % 5 == 0)
    {
        result.Append("Buzz");
    }

    return result.ToString();
}


