using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa3.Interfaces
{
    // A interface ICalculadora tem o objetivo de
    // abstrair o comportamento genérico de uma
    // calculadora comum, possuindo operações básicas
    // como Soma, Subtração, Multiplicação e Divisão
    // (os quais serão traduzidos para métodos).
    // Basicamente, o contrato que essa interface estabelece
    // é: para determinada classe ser considerada uma
    // calculadora, será necessário seguir as regras estabelecidas
    // (sobrescrever os métodos e atribuir funcionalidades a
    // eles).
    public interface ICalculadora
    {
        // Não é necessário escrever qualquer operador
        // pois já se subentende que todos os métodos
        // escritos serão "public" e "abstract"
		int Somar(int n1, int n2);
		int Subtrair(int n1, int n2);
		int Multiplicar(int n1, int n2);
		int Dividir(int n1, int n2);
	}
}