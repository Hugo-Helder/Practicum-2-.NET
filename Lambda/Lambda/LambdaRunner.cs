using System;
using System.Text;

namespace Lambda
{
    static class LambdaRunner
    {
        public static string RunAllMethods(int numOne, int numTwo, int numThree)
        {
            var output = new StringBuilder();

            // TimesThree rewritten as a lambda expression would look like the following:
            // Func<int, int> timesThree = x => 3 * x;
            //
            // However, C# has a shorter way of writing this:
            // static int TimesThree(int x) => 3 * x;
            //
            // This is called a Local Function (https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions)
            
            Func<int, int> timesThree = x => 3 * x;
            output.AppendFormat("x => 3 * x, met x={0} = {1}", numOne, timesThree(numOne)); 

            // ... Rewrite all the other methods as a lambda expression (or local function)

            return output.ToString();
        }
    }
}