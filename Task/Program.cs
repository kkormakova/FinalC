string[] array1 = new string[5] { "09744", "6774", "hello", "123", "arc" };
string[] array2 = new string[array1.Length];
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