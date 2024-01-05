Console.WriteLine(string.Join(' ', PlusOne(new int[] { 1, 2, 3 })));
Console.WriteLine(string.Join(' ', PlusOne(new int[] { 4, 3, 2, 1 })));
Console.WriteLine(string.Join(' ', PlusOne(new int[] { 9 })));
Console.WriteLine(string.Join(' ', PlusOne(new int[] { 9, 9, 9, 9, 9, 9 })));
Console.WriteLine(string.Join(' ', PlusOne(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })));
Console.WriteLine(string.Join(' ', PlusOne(new int[] { 8, 9, 9, 9 })));
Console.WriteLine(string.Join(' ',
    PlusOne(new[]
    {
        7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7,
        9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6
    })));

int[] PlusOne(int[] digits)
{
    digits[^1] += 1;

    List<int> result = new();

    for (int i = 0; i < digits.Reverse().ToArray().Length; i++)
    {
        if (digits[i] % 10 == 0)
        {
            if (i + 1 < digits.Length)
            {
                digits[i + 1] += 1;
            }
            else
            {
                result.Add(1);
            }
            
            result.Add(0);
        }
        else
        {
            result.Add(digits[i]);
        }
    }

    return result.ToArray();
}