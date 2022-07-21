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

int[] mass = new int[8];
CreateRandArr(mass);
PrintArr(mass);
Console.WriteLine();

Console.Write("Введите искомое число: ");
int A = int.Parse(Console.ReadLine());

bool find = false;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] == A)
    {
        find = true;
        break;
    }
}

if (find == true)
{
    Console.WriteLine("Число " + A + " присутствует в массиве");
}
else
{
    Console.WriteLine("Число " + A + " не присутствует в массиве");
}
