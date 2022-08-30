// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


Random random = new Random();
int rows = 4;
int colums = 5;
int [,] array = new int[rows, colums];
Fillarray(array);
Printarray(array);
Console.WriteLine("Введите номер строки: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());
Elements(array);


    void Elements(int[,] array)
{
    int element;
    if (numberRow >= 1 && numberRow <= rows && numberColumn >= 1 && numberColumn <= colums)
    {
        element = array[numberRow - 1, numberColumn -1];
        Console.WriteLine($"Искомый элемент это {element}");
    }
    else
    {
        Console.WriteLine(" Искомого элемента нет");
    }
}
    void Fillarray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
        
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
               {
                   array[i, j] = random.Next(0 , 9);
               }
    }
}
    void Printarray(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
            {
                Console.Write(array[i, j] + " ");
            }
               Console.WriteLine();
    }
}
  