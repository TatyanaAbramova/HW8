// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int n = InputNumbers("Какое количество строк треугольника вывести на экран: ");

double[,] PTriangle = new double[n + 1, 2 * n + 1];

FillPTriangle(PTriangle);

Console.WriteLine();
WriteArray(PTriangle);

TransformPTriangle(PTriangle);

Console.WriteLine();
WriteArray(PTriangle);

void TransformPTriangle(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

void FillPTriangle(double[,] PTriangle)
{
  for (int k = 0; k < PTriangle.GetLength(0); k++)
  {
    PTriangle[k, 0] = 1;
  }
  for (int i = 1; i < PTriangle.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      PTriangle[i, j] = PTriangle[i - 1, j] + PTriangle[i - 1, j - 1];
    }
  }
}

void WriteArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Console.Write($"{array[i, j]} ");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}