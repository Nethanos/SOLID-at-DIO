using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple
{
	public class PagamentoRequest
	{

		public double valor { get; set; }

		public TipoPagamento tipoPagamento { get; set; }

		public int quantidadeParcelas { get; set; }

		public PagamentoRequest(TipoPagamento tipoPagamento, double valor)
		{
			this.valor = valor;
		}
	}
}
