using Open_Closed_Principle.OpenClosedExample;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
	public class EmissorComprovante
	{

		/**
		 * Desafio 2
		 */
		public Comprovante EmitirComprovanteDebito(double valor, TipoPagamento tipoPagamento)
		{

			Comprovante comprovante = new Comprovante("Pagamento realizado", valor.ToString(), tipoPagamento);
			try
			{

				string usuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

				if (!string.IsNullOrEmpty(usuarioLogado)) {
					Database.save(comprovante);
					comprovante.usuarioLogado = usuarioLogado;
				}

			} catch (Exception exception) {
				// Validar erro.
							
			}

			return comprovante;

		}


		public Comprovante EmitirComprovanteCredito(double valor, TipoPagamento tipoPagamento, int numeroParcelas)
		{

			Comprovante comprovante = new ComprovanteCredito("Pagamento realizado", valor.ToString(), tipoPagamento, numeroParcelas);
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
