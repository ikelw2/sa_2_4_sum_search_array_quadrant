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

//Console.WriteLine("\nEnter XY point coordinates to determine in which quadrant it lies.");
while (true)
{
    //Console.Clear();
    Console.WriteLine("\n-------------------");
    Console.Write("Enter a double value for the X coordinate (left-right) --> ");
    double xCoord = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter a double value for the Y coordinate (up-down) --> ");
    double yCoord = Convert.ToDouble(Console.ReadLine());

    // a poss improved method to determine this would be to use geometric math




    // new solution using trig, after researching the function online

    // 1. Calculate angle from origin to x-y point (output in radians)
    int angleInDegrees = Convert.ToInt32(Math.Atan2(yCoord, xCoord) * (180 / Math.PI));
    // Console.WriteLine("before:  angleInDegrees = " + angleInDegrees);

    if (angleInDegrees < 0)  // required adjustment because Atan2 returns between -180 to +180 in degrees
    {
        angleInDegrees += 360;
    }
    //Console.WriteLine("after:  angleInDegrees = " + angleInDegrees + "      to get quad I take angle / 90");
    int quadrant = Convert.ToInt32((angleInDegrees) / 90) + 1;


    // notes for sharing
    //double angleFromOriginToPointInRadians = Math.Atan2(yCoord, xCoord);
    //double angleFromOriginToPointInDegrees = angleFromOriginToPointInRadians * (180 / Math.PI);
    //int angleInDegreesAsInteger = Convert.ToInt32(angleFromOriginToPointInDegrees);
    //if (angleInDegreesAsInteger < 0)
    //{
    //        angleInDegreesAsInteger += 360; // required conditional because Atan2 returns between -180 to +180 in degrees, not between 0 and 360 degrees
    //}
    //int quadrant = ((angleInDegreesAsInteger) / 90) + 1; // add one because result returns between 0 and 3, we want between 1 and 4








    // old solution using logic and conditions-----------------

    // // part 1: use logic to determine top/bottom and left/right variance
    // bool isTop = false;
    // if (yCoord >= 0)
    // {
    //     isTop = true;
    // }
    // bool isRight = false;
    // if (xCoord >= 0)
    // {
    //     isRight = true;
    // }

    // // part 2: use logic following isTop and isRight to assign quadrant
    // string quadrant = "undetermined";
    // if (isTop) 
    // {
    //     if (isRight)
    //     {
    //         quadrant = "I";
    //     }
    //     if (!isRight)
    //     {
    //         quadrant = "II";
    //     }
    // }
    // else // isTop == false
    // {
    //     if (isRight)
    //     {
    //         quadrant = "III";
    //     }
    //     if (!isRight)
    //     {
    //         quadrant = "IV";
    //     }
    // }

    Console.WriteLine($"The XY point at ({xCoord}, {yCoord}) is in quadrant {quadrant}.");

    Console.Write("Press Q to quit or ENTER to test the function again.");
    
    string repeatAgain = Console.ReadLine();
    if (repeatAgain.Trim().Equals("q", StringComparison.OrdinalIgnoreCase) == true)
    {
        break;
    }


}
// Test Data :
// Input the value for X coordinate :7
// Input the value for Y coordinate :9
// Expected Output :
// The coordinate point(7, 9) lies in the First quadrant.
#endregion




#region ShutdownTasks
// ------------------------------------------------------------------------
// End of Code, wait for user to press enter, and clear background
//Console.ReadLine();  // redundant since in 3rd part user already asked if they want to quit etc
AnsiConsole.Clear();
//
#endregion
