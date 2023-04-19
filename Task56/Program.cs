// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка


int[,] CreateArray(int n, int m) // Создаем двухмерный массив
{
    int[,] Array = new int[n, m];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 30);
        }
    }

    return Array;
}

void CheckMandN (int m, int n)
{
    if (m != n) 
    {
        System.Console.WriteLine("Массив с такими параметрами имеет прямоугольную форму, удовлетворяющая условие!");
        
    }
    else if( m == n) 
    {
        System.Console.WriteLine("По услувовию массив должен быть прямоугольным!");
        throw new IndexOutOfRangeException();
    }
}

 void PrintArray(int[,] Array) // вывод массива
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i, j] + "  ");

        }
        System.Console.WriteLine();
    }
} 

int IntRead(string arg)
{
    System.Console.WriteLine(arg);
    return int.Parse(Console.ReadLine());
}

void StrokaWithMinSum (int[,] array)
{
    int stroka = 0;
    int minsum = 200;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum +=array[i,j];
        }
        if (sum<minsum)
        {
            stroka = i;
            minsum = sum;
        }
    }
    System.Console.WriteLine($"Строка с наименьшей суммой элементов равная {minsum} и находиться на {stroka} индекс - строке.");
}



int n = IntRead($"Введите число n: ");
int m = IntRead($"Введите число m: ");
CheckMandN(n,m);
int [,] Array = CreateArray(n,m);
PrintArray(Array);
StrokaWithMinSum(Array);