using OpenClosedPrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Closed_Principle.OpenClosedExample
{
	public class ComprovanteCredito : Comprovante
	{

		public int numeroParcelas { get; set; }

		public ComprovanteCredito(string descricao, string valor, TipoPagamento tipoPagamento, int numeroParcelas) : base(descricao, valor, tipoPagamento)
		{
			this.numeroParcelas = numeroParcelas;
		}
	}
}
