// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void CreateRandArr(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(1, 10);
    }
}

void PrintArr(int[] arr2)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        Console.Write(arr2[j] + " ");
    }
}

int[] massiv = new int[5];
CreateRandArr(massiv);
PrintArr(massiv);
Console.WriteLine();

int[] massNew = new int [(massiv.Length + 1) / 2];

massNew[massNew.Length - 1] = massiv[massiv.Length / 2]; // затираем посл.эл-т нового массива на средний эл-т старого массива
//если в massiv нечётное кол0во эл-тов, то мы не трогам этот? элемент
for (int i = 0; i < massiv.Length / 2; i++)
{
    massNew[i] = massiv[i] * massiv[massiv.Length - 1 - i];
}
PrintArr(massNew);