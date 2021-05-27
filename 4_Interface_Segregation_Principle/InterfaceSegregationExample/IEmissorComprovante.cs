using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationExample
{
	public interface IEmissorComprovante
	{

		public Comprovante EmitirComprovante(PagamentoRequest pagamentoRequest);

		public void ChecarLimiteDeCredito();
	}
}
