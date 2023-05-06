internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[] { 23, 47, 12, 9 };

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

        Console.WriteLine();
        
        // Método para imprimir array em tela;
        printArray(ref arr);

        // Redimensionando um Array
        Array.Resize(ref arr, arr.Length * 2);
        Console.Write("Array Original: ");
        printArray(ref arr);

        // Redimensionando um Array com copy
        int[] newArr = new int[arr.Length];
        Array.Copy(arr, newArr, arr.Length);
        Console.Write("Array Copia: ");
        printArray(ref newArr);


    }

    public static void printArray(ref int[] arr)
    {
        Console.Write("[ ");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr.Length - i == 1) Console.WriteLine($"{arr[i]} ]");
            else Console.Write($"{arr[i]}, ");
        }
    }
}