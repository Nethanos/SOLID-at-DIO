using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
	public class PagamentoRequest
	{

		public double valor { get; set; }

		public TipoPagamento tipoPagamento { get; set; }

		public int numeroParcelas { get; set; }

		public PagamentoRequest(TipoPagamento tipoPagamento, double valor, int numeroParcelas)
		{
			this.valor = valor;

			this.tipoPagamento = tipoPagamento;

			this.numeroParcelas = numeroParcelas;
		}

		public PagamentoRequest(TipoPagamento tipoPagamento, double valor)
		{
			this.tipoPagamento = tipoPagamento;
			this.valor = valor;
		}
	}
}
