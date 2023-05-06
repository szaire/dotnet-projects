using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysListas.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números inteiros
        /// </summary>
        /// <param name="x">O primeiro número intero</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Somar(int x, int y)
        {
            Somar(3, 4);
        }

        /// <summary>
        /// Realiza a subtração entre dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        /// <returns>Retorna o resultado da subtração entre x e y</returns>
        public int Subtrair(int x, int y)
        {
            Subtrair(3, 4);
            return x - y;
        }
        public void Multiplicar();
        public void Dividr();
    }
}