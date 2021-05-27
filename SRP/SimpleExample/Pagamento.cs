using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.SimpleExample
{
	public class Pagamento
	{

		double valor;

		Comprovante Comprovante;

		public Pagamento(Comprovante comprovante, double valor)
		{
			Comprovante = comprovante;
			this.valor = valor;
		}

		public Pagamento() { 
		
		}
	}
}
