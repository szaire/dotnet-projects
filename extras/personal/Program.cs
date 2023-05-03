int squareSize = 10;
for (int i = 0; i < squareSize; i++)
{
    for (int j = 0; j < squareSize; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < squareSize; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

for (int i = 0; i < squareSize; i++)
{
    for (int j = squareSize-1; j > i; j--)
    {
        Console.Write("  ");
    }
    for (int k = 0; k <= i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}