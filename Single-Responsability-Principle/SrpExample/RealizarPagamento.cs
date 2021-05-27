using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple
{
	public class RealizarPagamento
	{
		private EmissorComprovante emissorComprovante = new EmissorComprovante();
		public Comprovante RegistrarPagamento(PagamentoRequest pagamento)
		{
			Comprovante comprovante = emissorComprovante.EmitirComprovante(pagamento.valor, pagamento.tipoPagamento);

			return comprovante;

		}	
	}
}
