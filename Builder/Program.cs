using Builder.Test;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
	class Program
	{
		private static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine(@"
To run tests write:
testAll
test1
test2
test3
					");
				var instrucction = Console.ReadLine();
				if (instrucction == "testAll")
				{
					BuilderTest.Test1();
					BuilderTest.Test2();
					BuilderTest.Test3();
				}
				else if (instrucction == "test1")
					BuilderTest.Test1();
				else if (instrucction == "test2")
					BuilderTest.Test2();
				else if (instrucction == "test3")
					BuilderTest.Test3();
			}
		}
	}
}
