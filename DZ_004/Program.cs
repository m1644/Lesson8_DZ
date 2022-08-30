// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = {{{12, 14}, {22, 24}}, {{32, 34}, {42, 44}}};

for(int i = 0; i < array.GetLength(0); i++) 
{
  for(int j = 0; j < array.GetLength(1); j++) 
  {
    for(int k = 0; k < array.GetLength(2); k++) 
    {
      Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
    }
  }
  Console.WriteLine();
}
