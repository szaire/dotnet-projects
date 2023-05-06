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
Array.Resize(ref arr, arr.Length*2);

// Como funciona o redimensionamento de Arrays?
int[] newArray = new int[4] {0, 1, 2, 3};

// Duplicando o tamanho do array:
int[] copyArray = new int[newArray.Length * 2];

for (int i = 0; i < newArray.Length; i++)
{
    copyArray[i] = newArray[i];
}

newArray = copyArray;

Console.WriteLine();

// Listas
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("AC");
listaString.Add("CE");

for (int i = 0; i < listaString.Count(); i++)
{
    Console.WriteLine($"Pos {i} = {listaString[i]}");
}

// Recomendado: Utilizar foreach para listas
foreach (string str in listaString)
{
    Console.Write(str + " ");
}
Console.WriteLine();