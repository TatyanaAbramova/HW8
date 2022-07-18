// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] arrayMass = new int[x, y, z];
CreateArray(arrayMass);
WriteArray(arrayMass);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] arrayMass)
{
  for (int i = 0; i < arrayMass.GetLength(0); i++)
  {
    for (int j = 0; j < arrayMass.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < arrayMass.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={arrayMass[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] arrayMass)
{
  int[] temp = new int[arrayMass.GetLength(0) * arrayMass.GetLength(1) * arrayMass.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arrayMass.GetLength(0); x++)
  {
    for (int y = 0; y < arrayMass.GetLength(1); y++)
    {
      for (int z = 0; z < arrayMass.GetLength(2); z++)
      {
        arrayMass[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
