// Заполните спирально массив 4 на 4.

int n = 4;
int[,] sqMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqMatrix.GetLength(0) * sqMatrix.GetLength(1))
{
  sqMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}