using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class LambdaRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            // methode TimesThree herschreven als lambda-expressie
            Func<int, int> timesThree = x => 3 * x;
            output.AppendFormat("x => 3 * x, met x={0} = {1}", num1, timesThree(num1)); 

            //aanvullen

            return output.ToString();
        }

    }
}
