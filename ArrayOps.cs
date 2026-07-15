using System;

namespace IntArrayOps;

public class IntegerArrayOperations
{

    public int MaxArrayElements { get; set; }
    public int[] IntegerArray { get; set; }

    public IntegerArrayOperations(int maxArrayElements = 3)
	{
        MaxArrayElements = maxArrayElements;
        IntegerArray = new int[MaxArrayElements];
    }    
    public int GetSumOfElements()
    {
        int runningTotal = 0;
        foreach (int item in IntegerArray)
        {
            runningTotal += item;
        }
        return runningTotal;
    }
    public int GetIndexOfHighestElement()
    {
        // initialize these two variables to the first index [0]
        int indexOfHighestElement = 0;
        int highestElement = IntegerArray[0];
        
        for (int i = 1; i < IntegerArray.Length; i++)
        {
            if (highestElement < IntegerArray[i])
            {
                highestElement = IntegerArray[i];
                indexOfHighestElement = i;
            }
        }
        return indexOfHighestElement;
    }
    public bool LoadElementsIntoArray()
    {
        if (IntegerArray != null)
        {
            Console.WriteLine($"\nSet {MaxArrayElements} values for the array.");
            for (int i = 0; i < IntegerArray.Length; i++)
            {
                Console.Write($"Input integer value for array[{i}]: ");
                IntegerArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return true;
        }
        else
        {
            Console.WriteLine("ERROR: Loading Elements Into Array Failed: Array is not initialized.");
            return false;
        }
    }
    public int GetValueAtIndex(int index)
    {
        if (IntegerArray != null)
        {
            return IntegerArray[index];
        }
        else
        {
            Console.WriteLine("ERROR: Unable to Get Value at Index: Array is not initialized.");
            return 0;
        }
    }
}
