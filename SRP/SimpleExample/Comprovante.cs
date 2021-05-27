using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.SimpleExample
{
	public class Comprovante
	{

		public Comprovante(string descricao, string valor)
		{
			this.descricao = descricao;
			this.valor = valor;
		}

		private string descricao { get; set; } 

		private string valor { get; set; }
	}
}
