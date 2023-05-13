using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa6.Models
{
    // Para determinar que uma classe é genérica, se adiciona <T> ao lado
    // da declaração da classe, que significa "Type";
    public class ArrayGenerico<T>
    {
		private int _tamanho;
		private T[] _array; // declaração de um array de tipo genérico
		private int _contador;

        public ArrayGenerico()
        {
			_tamanho = 10;
			_array = new T[_tamanho];
			_contador = 0;
		}

        // Méotodo para adicionar elementos ao array genérico
		public void Adicionar(T elemento)
        {
            if (_contador < _array.Length)
            {
				_array[_contador] = elemento;
			}
			_contador++;
		}

		// Indexer: Método especial semelhante à propriedade que permite
		// utilizar índices como parâmetro para retorno de um elemento de um
		// array
		public T this[int index]
		{
			get => _array[index];
			set => _array[index] = value;
		}

		public int Tamanho 
		{ 
			get => _tamanho;
			set => _tamanho = value;
		}
	}
}