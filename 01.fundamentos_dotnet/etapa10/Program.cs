using System;
using fundamentos_dotnet.etapa11.models;

Console.Write("Escreva um número: ");
int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Escreva outro número: ");
// int b = Convert.ToInt32(Console.ReadLine());

Calculadora calc = new Calculadora();

// calc.Somar(a, b);
// calc.Subtrair(a, b);
// calc.Multiplicar(a, b);
// calc.Dividir(a, b);
// calc.Potencia(a, b);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
calc.RaizQuadrada(a);

int num = 10;
Console.WriteLine($"Numero: {num}");

Console.WriteLine($"Incrementando o {num}");
num++;
Console.WriteLine($"Numero: {num}");

Console.WriteLine($"Decrementando o {num}");
num--;
Console.WriteLine($"Numero: {num}");