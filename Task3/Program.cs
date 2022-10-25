// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillMatrix (int[,] matrix,int min, int max)
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
            Console.Write(matrix[i,j]);
            Console.WriteLine();
       }
}
int []  FindStringSum (int[,] matrix)
{ 
  int[] sumarray = new int [matrix.GetLength(0)];
    
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum = sum + matrix[i,j];      
    }
    sumarray[i] = sum;
    
  }
  return sumarray;

}
int FindMinPositionSum (int[] array)
{
  int result = 1;
  for (int i = 0; i < array.Length; i++)
    {
      int min = array[0];
      if (array[i]<min)
      {
      min = array[i];
      result = i;
      }  
    }
  return result;
}
Console.WriteLine("Задайте размер массива mxn, в котором m и n не равны");
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()?? "0");
int [,] matrix = new int [m,n];

FillMatrix(matrix, 0,10);
PrintMatrix(matrix);
FindStringSum (matrix);
int [] sumarray = FindStringSum (matrix);  
Console.Write($"Суммы строк ");
for (int i = 0; i < sumarray.Length; i++)
{
  Console.Write($"{sumarray[i]} ");
}
int rowsnumber = FindMinPositionSum (sumarray);

Console.WriteLine();
Console.Write($"Наименьшая сумма элементов находится в {rowsnumber} строке ");

