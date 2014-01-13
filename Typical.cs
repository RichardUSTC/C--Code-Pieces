//using a namespace
using System;

//define a namespace
namespace Program
{
	// define a class
	// public, protected, private, internal
	class Test
	{
		// byte, ushort, uint, ulong
		// sbyte, short, int, long
		private int i;
		// sizeof(char) == 2
		private String s = "Hello, World.";

		private static int n = 0;

		public int I
		{
			get { return i; }
			set { i = value; } //value is a contextual key word
		}

		public static int N
		{
			get { return n; }
		}

		// indexer
		public int this[int index]
		{
			get{ return s[index]; }
		}

		// constructor 1
		public Test()
		{
			n++;
		}

		// constructor 2
		public Test(int i, String s)
		{
			this.i = i;
			this.s = s;
			n++;
		}
		// finalizer, called when the GC frees the object.
		// access modifier does not make sense here.
		~Test()
		{
			n--;
			System.Console.WriteLine("There are {0} entities of 'Test' type left.", Test.N);
		}
		// static constructor
		// NOTE: static field is initialized before the staic constructor
		// No access modifier for static constructor
		static Test()
		{
			System.Console.WriteLine("Type Initialized.");
		}

		//method
		void add(ref Test t1, out Test t2)
		{
			// t1 must be initialized before the call
			// while t2 must be assigned before use.
			t2 = new Test();
			t2.i = this.i + t1.i;
			t2.s = this.s + t1.s;
		}

		//override the default ToString method.
		public override String ToString()
		{
			return i.ToString() + ":" + s;
		}

		// static void Main()
		// static void Main(String []args)
		// static int Main()
		// NOTE: args[0] is not the path of the executable
		static int Main(String []args)
		{
			Test t0 = new Test(0, "0");
			Test t1 = new Test(1, "1");
			Test t2;
			t0.add(ref t1, out t2);
			System.Console.WriteLine("t2 = {0}", t2);
			System.Console.WriteLine("There are {0} entities of 'Test' type.", Test.N);
			t0 = t1 = t2 = null;
			return 0;
		}
	}
}