// (35) Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
void CreateRandArr(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(0, 200);
    }
}

void PrintArr(int[] arr2)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        Console.Write(arr2[j] + " ");
    }
}

void Count(int[] arr3)
{
    int count = 0;
    int index = 0;

    while (index < arr3.Length)
    {
        if (arr3[index] >= 10 && arr3[index] < 100)
        {
            count++;
        }
        index++;
    }
    Console.Write("Количество элементов в массиве в промежутке от 10 до 99: " + count);
}

int[] massiv = new int[123];
CreateRandArr(massiv);
PrintArr(massiv);
Console.WriteLine();
//Count(massiv);