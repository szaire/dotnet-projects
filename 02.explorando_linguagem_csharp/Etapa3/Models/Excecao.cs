using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa3.Models
{
    public class Excecao
    {
        // Retorna exceção para o Metodo1 e é tratada.
        // Delega o tratamento para si mesma e trata a exceção
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
				Console.WriteLine($"Uma exceção foi tratada! {ex.Message}");
				Console.WriteLine($"Caminho da exceção:\n\n{ex.StackTrace}");
			}
		}

        // Retorna exceção para o Metodo2, porém, não é tratada.
        // Delega o tratamento para um método superior
        public void Metodo2()
        {
            Metodo3();
			Console.WriteLine("Executa outras instruções...");
        }

        // Retorna exceção para o Metodo3, porém, não é tratada.
        // Delega o tratamento para um método superior
        public void Metodo3()
        {
			Metodo4();
			Console.WriteLine("Executa outras instruções...");
		}

        // A exceção será lançada e retornada até que seja tratada.
        public void Metodo4()
        {
			throw new Exception("Uma exceção foi lançada");
		}
    }
}