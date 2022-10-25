// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная).
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

void ChangeRowsToColumbsMatrix(int[,] matrix)
{   
    if (matrix.GetLength(0)==matrix.GetLength(1))
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
      
       for (int j = i; j < matrix.GetLength(1); j++) 
       {
        int z = matrix [i,j];
        matrix [i,j] = matrix [j,i];
        matrix [j,i] = z;        
       }
    }
    else return;
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
ChangeRowsToColumbsMatrix (matrix);
PrintMatrix  (matrix);
if (m!=n)
Console.WriteLine("Замена невозможна, матрица прежняя");

