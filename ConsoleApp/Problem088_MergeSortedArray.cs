// See https://aka.ms/new-console-template for more information
internal class Problem088_MergeSortedArray
{
    public Problem088_MergeSortedArray()
    {
        Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        //Merge([2, 0], 1, [1], 1);
        //Merge([4, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        //Merge([1], 1, [], 0);
        //Merge([0], 0, [1], 1);
    }

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var ptM = 0;
        var ptN = 0;
        var clone = nums1.Clone() as int[];

        for (int i = 0; i < nums1.Length; i++)
        {
            Console.Write($"{i} - ptN:{ptN} - ptM:{ptM} - clone[ptM]:{clone[ptM]} - nums2:{nums2[ptN]}");
            if (ptN >= n || (ptM < m && clone[ptM] <= nums2[ptN]))
            {
                nums1[i] = clone[ptM++];
            }
            else
            {
                nums1[i] = nums2[ptN++];
            }

            Console.WriteLine($" - {nums1[i]}");
        }

        PrintArray(nums1);
    }

    public void Merge3(int[] nums1, int m, int[] nums2, int n)
    {
        var clone = nums1.Clone() as int[];
        var ptM = 0;
        var ptN = 0;

        for (int i = m; i < nums1.Length; i++)
        {
            nums1[i] = nums2[ptN++];
        }

        //Array.Sort(nums1);

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = i + 1; j < nums1.Length; j++)
            {
                if (nums1[i] > nums1[j])
                {
                    var temp = nums1[i];
                    nums1[i] = nums1[j];
                    nums1[j] = temp;
                }
            }
        }

        PrintArray(nums1);
    }

    private static void PrintArray(int[] array)
    {
        Console.WriteLine($"Array: {string.Join(",", array)}");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("--- x ---");
    }

    public void Merge2(int[] nums1, int m, int[] nums2, int n)
    {
        var clone = nums1.Clone() as int[];

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(clone[i]);
        }
    }
}
/*
1: [1,2,3]
2: [2,5,6]


*/