using System;

namespace Program
{
	class Test
	{
		public static int Main(String []args)
		{
			String input;
			int i;
			System.Console.WriteLine("Input a number.");
			input = System.Console.ReadLine();
			try
			{
				i = System.Convert.ToInt32(input);
			}
			catch(FormatException e)
			{
				System.Console.WriteLine("Input is not number");
				return 2;
			}

			if(i>=0)
			{
				System.Console.WriteLine("Input is a non-negative number.");
				while (i>=0)
				{
					System.Console.WriteLine("In a while loop.");
					System.Console.WriteLine("i={0}", i);
					i--;
				}
				do
				{
					System.Console.WriteLine("In a do-while loop.");
					System.Console.WriteLine("i={0}", i);
				} while(i>=0);
			}
			else
			{
				System.Console.WriteLine("Input is a negative number.");
			}

			int []array = {1, 2, 3, 4, 5};
			for(i=0; i<array.Length; i++)
			{
				System.Console.WriteLine("array[{0}] = {1}", i, array[i]);
			}

			foreach(int item in array)
			{
				System.Console.Write("{0}, ", item);
			}
			System.Console.WriteLine("");

			switch(i)
			{
				case 0:
				case 1:
					System.Console.WriteLine("0 or 1.");
					break;
				case 2:
					System.Console.Write("2 or 3.");
					break;
				case 3:
					goto case 2;
				default:
					System.Console.WriteLine("None of 0, 1, 2 or 3.");
					break;
			}

			return 0;
		}
	}
}