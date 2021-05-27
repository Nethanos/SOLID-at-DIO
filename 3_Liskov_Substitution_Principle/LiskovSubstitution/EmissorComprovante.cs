using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionExample
{
	public class EmissorComprovante
	{

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


		public ComprovanteCredito EmitirComprovanteCredito(double valor, TipoPagamento tipoPagamento, int numeroParcelas)
		{

			ComprovanteCredito comprovante = new ComprovanteCredito("Pagamento realizado", valor.ToString(), tipoPagamento, numeroParcelas);
			try
			{

				string usuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

				if (!string.IsNullOrEmpty(usuarioLogado))
				{

					ChecarLimiteDeCredito();

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

		public void ChecarLimiteDeCredito()
		{

			Console.WriteLine("Checando limite");
		}
	}
}
