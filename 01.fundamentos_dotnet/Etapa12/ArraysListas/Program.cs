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

// Usando o copy:
int[] newArr = new int[arr.Length * 2];
Array.Copy(arr, newArr, arr.Length);

// Método sequencial:
int[] newArr2 = new int[arr.Length * 2];

for (int i = 0; i < arr.Length; i++)
{
    newArr2[i] = arr[i];
}

// Listas