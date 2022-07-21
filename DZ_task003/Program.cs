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