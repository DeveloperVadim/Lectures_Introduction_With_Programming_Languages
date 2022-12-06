int[,] matrix=new int[3,4];
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) -строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) -столбцы
    {
        Console.Write($"{matrix[i,j]} ");
    }
     Console.WriteLine();
}
