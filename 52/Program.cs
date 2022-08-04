//  Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j] = new Random().Next(1, 10)}");
        }
        Console.WriteLine();
    }
}

string MeanColoumnsArr(int[,] matr)
{
    int rows = matr.GetLength(0);
    int coloumns = matr.GetLength(1);

    for (int j = 0; j < coloumns; j++)
    {
        double newResult = 0;
        double result = 0;
        for (int i = 0; i < rows; i++)
        {
            result += matr[i, j];

        }
        newResult = result / rows;
        Console.WriteLine($"Среднее арифметическое для {j + 1}-го столбца: {newResult}");
    }
    return "";
}

int[,] matrix = new int[4, 5];
FillArray(matrix);
Console.WriteLine(MeanColoumnsArr(matrix));