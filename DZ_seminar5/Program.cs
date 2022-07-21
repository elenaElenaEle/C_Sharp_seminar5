// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2*************************************************************************************************
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

*****************************************************************************************************************************************

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

*********************************************************************************************************************************************

//Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементами массива.
// [3 7 22 2 78] -> 76

void CreateRandArr(double[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
    }
}
void PrintArr(double[] arr2)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        Console.Write(arr2[j] + " ");
    }
}


double[] massiv = new double[6];
CreateRandArr(massiv);
PrintArr(massiv);
Console.WriteLine();


double max = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (max < massiv[i])
    {
        max = massiv[i];
    }
}
Console.Write("Max: " + max);
Console.WriteLine();

double min = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (min > massiv[i])
    {
        min = massiv[i];
    }
}
Console.Write("Min: " + min);
Console.WriteLine();

double answ = max - min;
Console.Write("Разница между максимальным и мимнимальным элементами массива: " + answ);