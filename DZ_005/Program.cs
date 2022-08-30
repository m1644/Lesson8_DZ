// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1) 
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0)
            {
                Console.Write($"{array[i,j]}\t");
            } 
            else Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

PrintArray(sqareMatrix);
