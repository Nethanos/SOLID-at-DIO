using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.SimpleExample
{
	public class RealizarPagamento
	{

		public Comprovante PagamentoEmDebito(double valor)
		{
			Comprovante comprovante = emitirComprovante(valor);

			return comprovante;
		}

		public Comprovante PagamentoEmCredito(double valor)
		{
			Comprovante comprovante = emitirComprovante(valor);

			return comprovante;
		}

		private Comprovante emitirComprovante(double valor)
		{
			Comprovante comprovante = new Comprovante("Pagamento realizado", valor.ToString());

			return comprovante;
		}
	}
}
