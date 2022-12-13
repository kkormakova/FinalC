string[] array1 = new string[5] { "097", "6774", "hello", "123", "arc" };
string[] array2 = new string[array1.Length];
CheckArray(array1, array2);
PrintArray(array2);


void CheckArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
