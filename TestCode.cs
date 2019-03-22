 // File: TestCode.cs

using System;
using UtilityMethods;

class TestCode
{
	static void Main(string[] args)
	{
		Console.WriteLine("Calling methods from MathLibrary.DLL:");

		if (args.Length != 2)
		{
			Console.WriteLine("Usage: TestCode <num1> <num2>");
			return;
		}

		long num1 = long.Parse(args[0]);
		long num2 = long.Parse(args[1]);

		long sum = AddClass.Add(num1, num2);
		long subract = SubtractionClass.Subtraction(num1, num2);
		long product = MultiplyClass.Multiply(num1, num2);
		long division = DivisionClass.Division(num1, num2);

		

		Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
		Console.WriteLine("{0} - {1} = {2}", num1, num2, subract);
		Console.WriteLine("{0} * {1} = {2}", num1, num2, product);
		Console.WriteLine("{0} / {1} = {2}", num1, num2, division);
	}
}