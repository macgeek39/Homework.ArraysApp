

/*
 * Create an array of 3 names. Ask the user which
 * number to select. When the user gives you a number, return that name.
 * Make sure to check for invalid number.
 */

// Ask the user which number to select
Console.WriteLine("Please select a number from 1 to 3: ");
int num = int.Parse(Console.ReadLine());

// Make sure to check for invalid numbers
if ( num <= 3)
{
	// Create an array of 3 names
	string[] firstName = new string[] { "Love", "John", "Levi" };
	
	// When the user gives you a number, return that name.
	Console.WriteLine($"You select {firstName[num - 1]} as name");
} 
else 
{
    Console.WriteLine("Your enter invalid number!");
}  

