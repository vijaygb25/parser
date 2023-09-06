using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluant.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] expressions = new string[]
			{
				"2+(3/4)",
				"1+(2+(3/4))"
			};

			foreach (string expression in expressions)
				Console.WriteLine("{0} = {1}",
					expression,
					new Expression(expression).Evaluate());
			Console.ReadLine();
		}
    }
}
