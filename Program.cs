var ints = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
var result = RemoveElement(ints, 2);
Console.WriteLine(result);

int RemoveElement(int[] nums, int val)
{
    for (int i = 0; i < nums.Length; i++)
    {
        int j = nums.Length - 1;
        int temp = 0;
        while (temp == val && val > 0 && j > 0)
        {
            temp = nums[j--];
            nums[i] = ;
        }
    }

    return nums.Length;
}