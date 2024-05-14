// See https://aka.ms/new-console-template for more information
internal class Problem088_MergeSortedArray
{
    public Problem088_MergeSortedArray()
    {
        Merge([1,8,9, 0, 0, 0], 3, [2, 5, 6], 3);
        //Merge([1, 2, 3, 0, 0, 0], 3, [1], 1);
        //Merge([1], 1, [], 0);
        //Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        //Merge([2, 0], 1, [1], 1);
        //Merge([4, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        //Merge([0], 0, [1], 1);
    }
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;
        int p2 = n - 1;
        int i = m + n - 1;

        while (p2 >= 0)
        {
            var n1 = p1 >= 0 ? nums1[p1] : 0;
            var n2 = nums2[p2];

            if (p1 >= 0 && n1 > n2)
                nums1[i--] = nums1[p1--];
            else
                nums1[i--] = nums2[p2--];
        }

        PrintArray(nums1);
    }
    public void Merge6(int[] nums1, int m, int[] nums2, int n)
    {
        var l = m - 1;
        var r = n - 1;
        var k = m + n - 1;

        while (l >= 0 && r >= 0)
        {
            var n1 = l >= 0 ? nums1[l] : 0;
            var n2 = nums2[r];

            if (nums1[l] > nums2[r])
            {
                nums1[k] = nums1[l--];
            }
            else
            {
                nums1[k] = nums2[r--];
            }
            k--;
        }

        while (l >= 0)
        {
            nums1[k--] = nums1[l--];
        }

        while (r >= 0)
        {
            nums1[k--] = nums2[r--];
        }

        PrintArray(nums1);
    }

    public void Merge5(int[] nums1, int m, int[] nums2, int n)
    {
        var x1 = m - 1;
        var x2 = n - 1;
        var k = m + n - 1;

        Console.WriteLine($"x2 - x1 - k - n1[x1] - n2[x2] -> n1[k]");
        while (x2 >= 0)
        {
            Console.Write($"{x2}  - {x1}  - {k} - {(x1 >= 0 ? nums1[x1] : 0)}      - {nums2[x2]}");
            if (x1 >= 0 && nums1[x1] > nums2[x2])
            {
                nums1[k--] = nums1[x1--];
            }
            else
            {
                nums1[k--] = nums2[x2--];
            }

            //Console.WriteLine($"      -> {nums1[k]}");
        }

        PrintArray(nums1);
    }

    public void Merge4(int[] nums1, int m, int[] nums2, int n)
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

        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.WriteLine(array[i]);
        //}

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
m = 3
n = 3
x1 = 2
x2 = 2
k = 5

x2 - x1 - k - n1[x1] - n2[x2] -> n1[k]
2  - 2  - 5 - 3      - 6      -> 6

*/