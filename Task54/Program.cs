// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


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

void CreatNewArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(1)-1; s++)
            {
                if(array[i,s]<array[i,s+1])
                {
                    int temp = array[i,s+1];
                    array[i,s+1] = array[i,s];
                    array[i,s] = temp;
                }
            }
        }
    }
}

int n = IntRead($"Введите число n: ");
int m = IntRead($"Введите число m: ");
int [,] Array = CreateArray(n,m);
PrintArray(Array);
CreatNewArray(Array);
System.Console.WriteLine();
PrintArray(Array);