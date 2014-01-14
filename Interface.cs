using System;

namespace Program
{
	interface IFoo
	{
		void foo();
	}
	interface IBar
	{
		void foo();
		void bar();
	}
	interface IParent
	{
		void parent();
	}
	//interface inheritance
	interface IChild: IParent
	{
		void child();
	}
	class Test:IFoo, IBar, IChild
	{
		void IFoo.foo()
		{
			System.Console.WriteLine("IFoo.foo");
		}
		void IBar.foo()
		{
			System.Console.WriteLine("IBar.foo");
		}
		// must have public access modifier here.
		public void bar()
		{
			System.Console.WriteLine("bar");
		}

		public void parent()
		{
			System.Console.WriteLine("parent");
		}

		public void child()
		{
			System.Console.WriteLine("child");
		}

		private static void Main()
		{
			Test t = new Test();
			IFoo f = t;
			f.foo();
			IBar b = t;
			b.foo();
			b.bar();
			IChild c = t;
			c.child();
			IParent p = t;
			p.parent();
		}
	}
}