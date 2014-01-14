using System;

namespace Program
{
	class Parent
	{
		// Can access i in Child
		protected int i;
		// Cannot access j in Child
		private int j;

		public Parent(int i, int j)
		{
			this.i = i;
			this.j = j;
		}

		public void foo()
		{
			System.Console.WriteLine("Parent.foo");
		}
		public virtual void bar()
		{
			System.Console.WriteLine("Parent.bar");
		}
		public override String ToString()
		{
			return "Parent:(" + i + ", " + "j)";
		}
	}
	class Child: Parent
	{
		// 'Child' does not have the constructor of 'Parent'
		public Child(int i, int j):base(i, j) {}
		// Should add the 'new' keyword while overwriting the method of 'Parent'.
		public new void foo()
		{
			System.Console.WriteLine("Child.foo");
		}
		// 'override' is essential here.
		public override void bar()
		{
			System.Console.WriteLine("Child.bar");
		}
		public override String ToString()
		{
			return "Child:(" + i + ", " + "j)";
		}
	}
	class Test
	{
		static void Main()
		{
			// Initialize
			Parent p1 = new Parent(0, 1);
			Child c1 = new Child(2, 3);
			System.Console.WriteLine("{0}\n{1}", p1, c1);

			if (c1 is Parent)
			{
				System.Console.WriteLine("The type of 'c1' is exactly 'Parent' or sub type of it.");
			}
			
			// Convert
			Parent p2 = c1 as Parent;
			p2.foo();
			p2.bar();

			Child c2 = p1 as Child;
			if (c2 == null)
			{
				System.Console.WriteLine("Convertion from 'Parent' to 'Child' failed.");
			}

			try
			{
				c2 = (Child) p1;
			}
			catch(InvalidCastException e)
			{
				System.Console.WriteLine("Invalid cast from 'Parent' to 'Child'");
			}
		}
	}
}