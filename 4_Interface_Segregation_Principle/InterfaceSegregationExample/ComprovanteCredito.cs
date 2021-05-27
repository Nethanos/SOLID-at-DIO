using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationExample
{
	public class ComprovanteCredito : Comprovante
	{

		public int numeroParcelas { get; set; }

		public ComprovanteCredito(string descricao, string valor, TipoPagamento tipoPagamento, int numeroParcelas) : base(descricao, valor, tipoPagamento)
		{
			this.numeroParcelas = numeroParcelas;
		}

		public override string AlertarPorEmail()
		{
			return $"O usuario {usuarioLogado} realizou o pagamento no valor de {valor}R$ utilizando a forma de pagamento {tipoPagamento} em {numeroParcelas} parcelas";
		}
	}
}
