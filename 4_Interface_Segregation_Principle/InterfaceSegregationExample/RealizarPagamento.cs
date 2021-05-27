using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregationExample
{
	public class RealizarPagamento
	{

		private IEmissorComprovante emissorComprovante;

		public RealizarPagamento(IEmissorComprovante emissorComprovante)
		{
			this.emissorComprovante = emissorComprovante;
		}
		public Comprovante RegistrarPagamento(PagamentoRequest pagamento)
		{
			Comprovante comprovante = emissorComprovante.EmitirComprovante(pagamento); ;

			return comprovante;

		}	
	}
}
