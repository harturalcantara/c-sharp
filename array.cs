// C# program to illustrate creating an array of integers, puts some values in the array, and prints each value to standard output.
using System;
	
class GFG {
	public static void Main() {
		// declares an Array of integers.
		int[] intArray;
		// allocating memory for 5 integers.
		intArray = new int[5];
		intArray[0] = 10;
		intArray[1] = 20;
		intArray[2] = 30;
		intArray[3] = 40;
		intArray[4] = 50;

		// accessing the elements
		// using for loop
		Console.Write("For loop :");
		for (int i = 0; i < intArray.Length; i++)
			Console.Write(" " + intArray[i]);
        // using for-each loop
		Console.WriteLine("");
		Console.Write("For-each loop :");
		foreach(int i in intArray)
			Console.Write(" " + i);
		// using while loop
        Console.WriteLine("");
		Console.Write("while loop :");
		int j = 0;
		while (j < intArray.Length) {
			Console.Write(" " + intArray[j]);
			j++;
		}
        // using do-while loop
		Console.WriteLine("");
		Console.Write("Do-while loop :");
		int k = 0;
		do {
			Console.Write(" " + intArray[k]);
			k++;
		} while (k < intArray.Length);
	}
}