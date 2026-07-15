// begin with pseudocode
using Spectre.Console;
using IntArrayOps;

#region StartupTasks
// Clearscreen and Welcome message using Spectre.Console
AnsiConsole.Clear();
AnsiConsole.Write(new Panel("[gray]Assignment 2.4: Basic Array Operations Demonstration[/]").BorderColor(Color.MediumVioletRed));

// declare array object for manipulation
Console.WriteLine("Input the number of elements to be stored in the array.");
Console.WriteLine("(array size will be used for both sum and highest element operations)");
Console.Write("Enter size: ");
int requestedSize = Convert.ToInt32(Console.ReadLine());
IntegerArrayOperations myArrayOps = new(requestedSize);
#endregion




// =========================================================================
// =========================================================================
// =========================================================================
#region 4_2_1_sum_of_array
// 1.Write a program in C# Sharp to find the sum of all array elements.

if (myArrayOps.LoadElementsIntoArray()) // if Load Element Operation successful
{
    int sumOfElements = myArrayOps.GetSumOfElements();
    Console.WriteLine($"\nSum of all elements stored in the array is: {sumOfElements}");
}

// Test Data :
//   Input the number of elements to be stored in the array :3
//   Input 3 elements in the array :
//   element - 0 : 2
//   element - 1 : 5
//   element - 2 : 8
// Expected Output :
//   Sum of all elements stored in the array is : 15
#endregion





// =========================================================================
// =========================================================================
// =========================================================================
#region 4_2_2_largest_of_array
// 2.Write a C# Sharp program to find the largest of three numbers (in an array)

if (myArrayOps.LoadElementsIntoArray()) // if Load Element Operation successful
{
    int indexOfHighestElement = myArrayOps.GetIndexOfHighestElement();
    Console.Write($"\nIndex of highest valued element stored in the array is: {indexOfHighestElement}. ");
    Console.WriteLine($"(IntegerArray[{indexOfHighestElement}] = {myArrayOps.GetValueAtIndex(indexOfHighestElement)})");
}

// Test Data :
//   Input the 1st number :25
//   Input the 2nd number :63
//   Input the 3rd number :10
// Expected Output :
//   The 2nd Number is the greatest among three
#endregion










// =========================================================================
// =========================================================================
// =========================================================================
#region 4_2_3_determine_quadrant
// 3. Write a C# Sharp program to accept a coordinate point in an XY coordinate
//    system and determine in which quadrant the coordinate point lies.

Console.WriteLine("\nEnter XY point coordinates to determine in which quadrant it lies.");
Console.Write("Enter a double value for the X coordinate (left-right) --> ");
double xCoord = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a double value for the Y coordinate (up-down) --> ");
double yCoord = Convert.ToDouble(Console.ReadLine());

// a poss improved method to determine this would be to use geometric math

// part 1: use logic to determine top/bottom and left/right variance
bool isTop = false;
if (yCoord >= 0)
{
    isTop = true;
}
bool isRight = false;
if (xCoord >= 0)
{
    isRight = true;
}

// part 2: use logic following isTop and isRight to assign quadrant
string quadrant = "undetermined";
if (isTop) 
{
    if (isRight)
    {
        quadrant = "I";
    }
    if (!isRight)
    {
        quadrant = "II";
    }
}
else // isTop == false
{
    if (isRight)
    {
        quadrant = "III";
    }
    if (!isRight)
    {
        quadrant = "IV";
    }
}

Console.WriteLine($"\nThe XY point at ({xCoord}, {yCoord}) is in quadrant {quadrant}.\n");

// Test Data :
// Input the value for X coordinate :7
// Input the value for Y coordinate :9
// Expected Output :
// The coordinate point(7, 9) lies in the First quadrant.
#endregion




#region ShutdownTasks
// ------------------------------------------------------------------------
// End of Code, wait for user to press enter, and clear background
Console.ReadLine();
AnsiConsole.Clear();
//
#endregion
