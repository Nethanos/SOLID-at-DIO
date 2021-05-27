using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloPagamento.src
{
	public class RealizarPagamento
	{
	
		public Comprovante RegistrarPagamento(PagamentoRequest pagamento)
		{
			Comprovante comprovante = emitirComprovante(pagamento.valor, pagamento.tipoPagamento);

			return comprovante;

		}

		private Comprovante emitirComprovante(double valor, TipoPagamento tipoPagamento)
		{
			Comprovante comprovante = new Comprovante("Pagamento realizado", valor.ToString(), tipoPagamento);

			Database.save(comprovante);

			return comprovante;
		}

	
	}
}
