// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void CreateRandArr(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(-10, 10);
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
int sum = 0;
for (int i = 1; i < massiv.Length; i = i +2)
{
    sum = massiv[i] + sum;
}
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);