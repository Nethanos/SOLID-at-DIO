using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
	public class RealizarPagamento
	{
		private EmissorComprovante emissorComprovante = new EmissorComprovante();

		/**
		 * Desafio 1
		 */
		public Comprovante RegistrarPagamento(PagamentoRequest pagamento)
		{
			Comprovante comprovante = null;

			if (pagamento.tipoPagamento.Equals(TipoPagamento.CREDITO))
			{
				comprovante = emissorComprovante.EmitirComprovanteCredito(pagamento.valor, pagamento.tipoPagamento, pagamento.numeroParcelas);
			}
			else
			{
				comprovante = emissorComprovante.EmitirComprovanteDebito(pagamento.valor, pagamento.tipoPagamento);
			}

			return comprovante;

		}	
	}
}
