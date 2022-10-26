// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 11);
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}

void SumMatrix(int[,] matrix)
{
    double sum = 0;
    int a = 0;
for (int j = 0; j < matrix.GetLength(1);j++)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
sum=sum + matrix[i, j];
a++;
}
Console.Write($"{sum/a} \t");
sum = 0;
a =  0;
}
}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.Write("Среднеарефметическое столбцов: ");
Console.WriteLine();
SumMatrix(matrix);
