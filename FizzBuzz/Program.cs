//using System;
using System.Diagnostics;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			for (var i = 1; i <= 100; i++)
			{
				if (i%3 == 0)
				{
					Debug.Write("Fizz");
				}

				if (i%5 == 0)
				{
					Debug.Write("Buzz");
				}

				if (i%3 != 0 && i%5 != 0)
				{
					Debug.Write(i);
				}

				Debug.WriteLine("");
			}

			//Console.WriteLine("Hit Enter to Quit.");
			//Console.ReadLine();
		}
	}
}
