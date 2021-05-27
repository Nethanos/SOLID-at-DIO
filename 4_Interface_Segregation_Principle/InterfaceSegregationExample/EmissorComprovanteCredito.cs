using InterfaceSegregationExample;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Interface_Segregation_Principle.InterfaceSegregationExample
{
	class EmissorComprovanteCredito : IEmissorComprovante
	{
		public Comprovante EmitirComprovante(PagamentoRequest pagamentoRequest)
		{

			ComprovanteCredito comprovante = new ComprovanteCredito("Pagamento realizado", pagamentoRequest.ToString(), pagamentoRequest.tipoPagamento, pagamentoRequest.numeroParcelas);
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
