// (32) Напишите программу замены элементов массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

void CreateRandArr (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
}

void PrintArr (int[] arr1)
{
    for (int j = 0; j < arr1.Length; j++)
    {
        Console.Write(arr1[j] + " ");
    }
}

void Invert (int[] arr2)
{
    for (int k = 0; k < arr2.Length; k++)
    {
        arr2[k] = - arr2[k];
    }
}
int[] massiv = new int[4];
CreateRandArr (massiv);
PrintArr (massiv);
Console.WriteLine();
Invert (massiv);
PrintArr (massiv);