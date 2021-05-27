using InterfaceSegregationExample;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Interface_Segregation_Principle.InterfaceSegregationExample
{
	class EmissorComprovanteDebito : IEmissorComprovante
	{
		public Comprovante EmitirComprovante(PagamentoRequest pagamentoRequest)
		{
			Comprovante comprovante = new Comprovante("Pagamento realizado", pagamentoRequest.valor.ToString(), pagamentoRequest.tipoPagamento);
			try
			{

				string usuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

				if (!string.IsNullOrEmpty(usuarioLogado))
				{
					Database.save(comprovante);
					comprovante.usuarioLogado = usuarioLogado;
				}

			}
			catch (Exception exception)
			{
				// Validar erro.

			}

			return comprovante;

		}
	}
}
