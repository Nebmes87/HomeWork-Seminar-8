// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int InputNumbers(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}
void GenerateArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");

int[,] firstMatrix = new int[m,n];
GenerateArray(firstMatrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[n,p];
GenerateArray(secondMatrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);