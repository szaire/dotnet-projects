using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa5.Models
{
	public class Produto
	{
		private int _id;
		private string _productName;
		private decimal _price;
		private DateTime _time;

		// DateTime com JSON
		public Produto(int id, string productName, decimal price, DateTime time)
		{
			Id = id;
			ProductName = productName;
			Price = price;
			Time = time;
		}

		public int Id
		{
			get => _id;
			set
			{
				if (value < 1)
				{
					_id = 0;
					throw new ArgumentException("Argumento Inválido! O ID não pode ser menor que 1");
				}
				_id = value;
			}
		}

		public string ProductName
		{
			get => _productName;
			set
			{
				if (value == "")
				{
					_productName = null;
					throw new ArgumentException("Argumento Inválido! O Nome do Produto não pode ser vazio.");
				}
				_productName = value;
			}
		}

		public decimal Price 
		{ 
			get => _price; 
			set
			{
				if (value < 0)
				{
					_price = 0;
					throw new ArgumentException("Argumento Inválido! O Preço do Produto não pode ser negativo.");
				}
				_price = value;
			} 
		}

		public DateTime Time 
		{ 
			get => _time; 
			set => _time = value; 
		}

		public string GetFileNameFormat() => ProductName.ToLower().Replace(" ", "_");
	}
}