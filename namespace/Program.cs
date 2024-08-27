using System;

namespace check1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a Number: ");
			int i = int.Parse(Console.ReadLine());

			if (i % 2 == 0)
			{
				Console.Write("Entered Number is an Even Number");
			}
			else
			{
				Console.Write("Entered Number is an Odd Number");
			}

			Console.ReadKey();  // Keeps the console open until a key is pressed
		}
	}
}
