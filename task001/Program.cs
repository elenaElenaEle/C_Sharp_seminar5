﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int[] mass = new int[12]; //обозначили что в массиве 12 элементов
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
Print(mass);

int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        sumPos += mass[i];
    }
    else
    {
        sumNeg += mass[i];
    }
}
Console.WriteLine();
Console.WriteLine("Положительные: " + sumPos);
Console.WriteLine("Отрицательные: " + sumNeg);
