int[,] matrix = new int[5, 6];
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        matrix[i, j] = random.Next(-10, 11);
    }
}
int sum = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        if (matrix[i, j] >= -2 && matrix[i, j] <= 3)
        {
            sum += matrix[i, j];
        }
    }
}
Console.WriteLine(" " + sum);
