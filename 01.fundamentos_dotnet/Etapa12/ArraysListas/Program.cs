int[] arr = new int[] {23, 47, 12, 9};

// Loop em array com For
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Posição nº {i} - {arr[i]}");
}

Console.WriteLine();

// Loop em array com Foreach
foreach (int var in arr)
{
    Console.WriteLine(var);
}

// Redimensionando um Array
Array.Resize(ref arr, arr.Length * 2);