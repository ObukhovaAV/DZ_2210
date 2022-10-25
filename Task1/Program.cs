// Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.
void FillMatrix (int [,] matrix, int min, int max)
{
     Random random = new Random();
     for (int i = 0; i < matrix.GetLength(0); i++)     
        for (int j = 0; j < matrix.GetLength(1); j++)        
         matrix[i,j] = random.Next(min,max);     
}
void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {     
        for (int j = 0; j < matrix.GetLength(1); j++)  
        Console.Write($" {matrix[i,j]} ");
        Console.WriteLine();
    }
}
void MatrixSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    int temporary = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temporary;
                }
            }
}
Console.WriteLine ("Задайте массив размером mxn");
Console.WriteLine ("Введите m");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine ("Введите n");
int n = int.Parse(Console.ReadLine() ?? "0");

int [,] matrix = new int [m,n];
FillMatrix (matrix, 1,20);
PrintMatrix (matrix);
Console.WriteLine();
MatrixSort(matrix);
PrintMatrix (matrix);
