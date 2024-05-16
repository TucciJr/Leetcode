// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp;
using System.Xml;

internal class Problem027_RemoveElement
{
    public Problem027_RemoveElement()
    {
        Console.WriteLine(RemoveElement([0,1,2,2,3,0,4,2], 2)); ;
        Console.WriteLine(RemoveElement([3, 2, 2, 3], 3)); ;
    }

    public int RemoveElement(int[] nums, int val)
    {
        var diffs = 0;
        var length = nums.Length;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] != val)
            {
                nums[diffs++] = nums[i];
            }
        }

        nums.Print();

        return diffs;
    }
}