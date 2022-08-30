// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Random random = new Random();
int rows = 4;
int colums = 5;
int [,] array = new int[rows, colums];
Fillarray(array);
Printarray(array);
Findaverage(array);
      
      void Findaverage(int[,] array)
{
        int stolb = 1;
        double average = 0;
        for (int j = 0; j < colums; j++)
        {
             double sum = 0;
             for (int i = 0; i < rows; i++)
            {
               sum = sum + array[i, j]; 
            }
            average = Math.Round(sum/rows, 1);
      
      Console.WriteLine($"среднее арифметическое в {stolb} столбце равно {average}");
      stolb++;
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
