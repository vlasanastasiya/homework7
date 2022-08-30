// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

      Random random = new Random();
      int rows = 3;
      int colums = 4;
      double[,] array = new double[rows, colums];
      Fillarray(array);
      Printarray(array);
     


    void Fillarray(double[,] array)
 {
      Random random = new Random();
      int rows = array.GetLength(0);
      int colums = array.GetLength(1);
      
      for (int i = 0; i < rows; i++)
      {
           for (int j = 0; j < colums; j++)
           {
               array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 1);
           }
      }
}
      void Printarray(double[,] array)
{
      int rows = array.GetLength(0);
      int colums = array.GetLength(1);
      for (int i = 0; i < rows; i++)
      {
           Console.Write("[");
           for (int j = 0; j < colums; j++)
           {
               Console.Write(array[i, j] + " ");
           }
           Console.Write("]");
           Console.WriteLine();
      }
}




