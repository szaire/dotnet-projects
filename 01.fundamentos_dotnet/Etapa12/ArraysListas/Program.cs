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

        Console.WriteLine();

        // Listas
        // trabalha internamente com um array, porém, não há a necessidade
        // de se preocupar com o armazenamento desse
        // É como se fosse um "array melhorado"

        // Sintaxe:
        List<string> listaString = new List<string>();

        // Lista dos estados:
        listaString.Add("SP");
        listaString.Add("BA");
        listaString.Add("MG");
        listaString.Add("AC");

        // Percorrendo uma lista com for:
        for (int i = 0; i < listaString.Count; i++)
        {
            Console.WriteLine($"Pos {i} : {listaString[i]}");
        }

        // Percorrendo uma lista com foreach (recomendado):
        int cnt = 0;
        foreach (string estado in listaString)
        {
            Console.WriteLine($"Pos {cnt} : {estado}");
            cnt++;
        }

        // Debugando a Lista:
        Console.WriteLine($"Qnt de itens na lista = {listaString.Count} || Capacidade = {listaString.Capacity}");

        listaString.Add("AL");
   
        Console.WriteLine($"Qnt de itens na lista = {listaString.Count} || Capacidade = {listaString.Capacity}");

        listaString.Remove("SP");

        Console.WriteLine($"Qnt de itens na lista = {listaString.Count} || Capacidade = {listaString.Capacity}");
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