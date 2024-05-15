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

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"{i} = {nums[i]} - {nums[i] == val}");

            Console.WriteLine($"{i} < {string.Join(",", nums)}");

            if (nums[i] != val)
            {
                diffs++;
            }
            else
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] != val)
                    {
                        diffs++;
                        nums[i] = nums[j];
                        nums[j] = val;
                        break;
                    }
                }
            }

            Console.WriteLine($"{i} < {string.Join(",", nums)}");
        }

        nums.Print();

        return diffs;
    }
}