// C# program to illustrate the
// use of null-coalescing operator(??)
using System;

class Program
{

	// Main Method
	static public void Main()
	{

		// a is nullable type
		// and contains null value
		int? a = null;


		// it means if a is null
		// then assign 3 to b
		int b = a ?? 3;

		// It will print 3
		Console.WriteLine(b);
	}
}



/*
 // C# program to illustrate Nullable Types
using System;

class Program
{

	// Main Method
	static void Main(string[] args)
	{

		// defining Nullable type
		Nullable<int> n = null;

		// using the method
		// output will be 0 as default
		// value of null is 0
		Console.WriteLine(n.GetValueOrDefault());

		// defining Nullable type
		int? n1 = null;

		// using the method
		// output will be 0 as default
		// value of null is 0
		Console.WriteLine(n1.GetValueOrDefault());


		// using Nullable type syntax
		// to define non-nullable
		int? n2 = 47;

		// using the method
		Console.WriteLine(n2.GetValueOrDefault());

		// using Nullable type syntax
		// to define non-nullable
		Nullable<int> n3 = 457;

		// using the method
		Console.WriteLine(n3.GetValueOrDefault());

	}

}
 */


/*
 // C# program to illustrate the
// use of Nullable type
using System;

class Program
{

	// Main Method
	static public void Main()
	{

		// a is nullable type
		// and contains null value
		int? a = null;

		// b is nullable type int
		// and behave as a normal int
		int? b = 2345;

		// this will not print
		// anything on console
		Console.WriteLine(a);

		// gives 2345 as output
		Console.WriteLine(b);
	}
}
 */

/*
 // C# program to illustrate the
// use of Nullable<L>.Hasvalue
using System;

class Program
{

	// Main Method
	static void Main()
	{

		// a is nullable type
		// and contains null value
		Nullable<int> a = null;

		// check the value of object
		Console.WriteLine(a.HasValue);

		// b is nullable type
		// and contains a value
		Nullable<int> b = 7;

		// check the value of object
		Console.WriteLine(b.HasValue);

	}
}


 */