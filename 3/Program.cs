int[] myArray = { 1, 2, 3, 4, 5 };
Console.Write("Reversed array: ");
PrintArrayReverse(myArray, myArray.Length - 1);

void PrintArrayReverse(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write(arr[index] + "\t");
        PrintArrayReverse(arr, index - 1);
    }
}