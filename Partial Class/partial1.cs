using System;

namespace Program
{
	partial class Test
	{
		public void method1()
		{
			System.Console.WriteLine("Method1 from 'partial1.cs'.");
		}
		public static void Main()
		{
			Test t = new Test();
			t.method1();
			t.method2();
		}
	}
}