


/*
 // C# program to declare string using
// string, String and System.String
// and initialization of string
using System;
class StringApplication
{

	// Main Method
	static void Main(string[] args)
	{

		// declare a string Name using
		// "System.String" class
		System.String Name;

		// initialization of String
		Name = "Payal";


		// declare a string id using
		// using an alias(shorthand)
		// "String" of System.String
		// class
		String id;

		// initialization of String
		id = "33";

		// declare a string mrk using
		// string keyword
		string mrk;

		// initialization of String
		mrk = "97";

		// Declaration and initialization of
		// the string in a single line
		string rank = "1";

		// Displaying Result
		Console.WriteLine("Name: {0}", Name);
		Console.WriteLine("Id: {0}", id);
		Console.WriteLine("Marks: {0}", mrk);
		Console.WriteLine("Rank: {0}", rank);
	}
}

 */


/*
 // C# program for an array of strings
using System;
class StringApplication
{

	// Main Method
	static void Main(string[] args)
	{

		String[] str_arr = new String[3];

		// Initialising the array of strings
		str_arr[0] = "HTML";
		str_arr[1] = "CSS";
		str_arr[2] = "JS";

		// printing String array
		for (int i = 0; i < 3; i++)
		{
			Console.WriteLine("value at Index position " + i + " is " + str_arr[i]);
		}

	}
}


 */

/*
 // C# program to demonstrate Reading
// String from User-Input
using System;
class StringApplication
{

	// Main Method
	static void Main(string[] args)
	{

		Console.WriteLine("Enter the String");

		// Declaring a string object read_user
		// and taking the user input using
		// ReadLine() method
		String read_user = Console.ReadLine();

		// Displaying the user input
		Console.WriteLine("User Entered: " + read_user);

	}

}
 */

/*
 // C# program to demonstrate the
// string creation using literals
using System;
class StringApplication
{

	// Main Method
	static void Main(string[] args)
	{
		string str1 = "Web Development";
		Console.WriteLine(str1);

		// Give Error Unrecognized escape sequence \H, \G, \p
		// string str3 = "X:\Home\GFG\Geeks.cs";
		// Console.WriteLine(str3);

		// using double slash \\
		string str2 = "X:\\Home\\DLithe\\program.cs";
		Console.WriteLine(str2);

	}
}

<!-->
// C# program to demonstrate the use of
// the string concatenation operator.
using System;
class StringApplication {

	// Main Method
	public static void Main()
	{
		string s1 = "HTML";
		string s2 = "CSS";
		string s3 = "JS";
		string s4 = "Csharp";

		// using concatenation operator
		string str = s1 + s2 + s3 + s4 + "Imp";

		Console.WriteLine(str);
	}
}

 */