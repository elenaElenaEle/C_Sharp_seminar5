// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void CreateRandArr(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(100, 1000);
    }
}
void PrintArr(int[] arr2)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        Console.Write(arr2[j] + " ");
    }
}

int[] massiv = new int[6];
CreateRandArr(massiv);
PrintArr(massiv);
Console.WriteLine();
int count = 0;
for (int index = 0; index < massiv.Length; index++)
{
    if (massiv[index] % 2 == 0)
    {
        count++;
    }
}
Console.Write("Количество чётных чисел в массиве: " + count);
