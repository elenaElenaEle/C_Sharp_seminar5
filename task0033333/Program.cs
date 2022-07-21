// (33) Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

void CreateRandArr(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(0, 100);
    }
}

void PrintArr(int[] arr2)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        Console.Write(arr2[j] + " ");
    }
}


bool isN = true;
void Serch(int[] arr3, int N)
{
    for (int k = 0; k < arr3.Length; k++)
    {
        if (arr3[k] == N)
        {
            isN = true;
            return;
        }
        else
        {
            isN = false;
        }
    }
}

void PrintBool(bool isN, int N)
{
    if (isN)
    {
        Console.WriteLine("Число " + N + " присутствует в массиве");
    }
    else
    {
        Console.WriteLine("Число " + N + " не присутствует в массиве");
    }
}
int[] massiv = new int[4];
CreateRandArr(massiv);
PrintArr(massiv);
Console.WriteLine();
Console.Write("Введите искомое число: ");
int A = int.Parse(Console.ReadLine());
Serch(massiv, A);
PrintBool(isN, A);