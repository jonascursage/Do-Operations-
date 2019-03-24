 // File: TestCode.cs

using System;
using UtilityMethods;
using UseOperations;

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


		OperationsCLass operation = new OperationsCLass();
		operation.Operations(num1, num2);
	}
}