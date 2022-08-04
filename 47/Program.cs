// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] FillArray(int x, int y)
{
   double[,] FillingArray = new double[x, y];
   for(int i = 0; i < FillingArray.GetLength(0); i++)
   {
      for (int j = 0; j < FillingArray.GetLength(1); j++)
      {
         FillingArray[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
      }
   }
   return FillingArray;
}

void PrintArray (double[,] Matrix)
{
   for(int i = 0; i < Matrix.GetLength(0); i++)
   {
      for (int j = 0; j < Matrix.GetLength(1); j++)
      {
         Console.Write($"{Matrix[i,j]}  /  ");
      }
      Console.WriteLine();
   }
}

double[,] array = FillArray(3, 4);
PrintArray(array);