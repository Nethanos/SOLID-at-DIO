using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsabilityPrinciple
{
	public class EmissorComprovante
	{

		public Comprovante EmitirComprovante(double valor, TipoPagamento tipoPagamento)
		{
			Comprovante comprovante = new Comprovante("Pagamento realizado", valor.ToString(), tipoPagamento);
			try
			{

				string usuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

				if (!string.IsNullOrEmpty(usuarioLogado)) {
					comprovante.usuarioLogado = usuarioLogado;
					Database.save(comprovante);
				}

				throw new Exception("Usuario não logado meu patrão");
			} catch (Exception exception) {
				// Validar erro.
							
			}

			return comprovante;

		}
	}
}
