using _4_Interface_Segregation_Principle.InterfaceSegregationExample;
using InterfaceSegregationExample;
using System;

namespace _4_Interface_Segregation_Principle
{
	class Program
	{
		static void Main(string[] args)
		{
			RealizarPagamento realizarPagamento = new RealizarPagamento(new EmissorComprovanteCredito());

			Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamentoCredito());


			Console.WriteLine(comprovante.AlertarPorEmail());

		}

		public static PagamentoRequest CriarPagamentoCredito()
		{
			return new PagamentoRequest(TipoPagamento.CREDITO, 30.0, 3);
		}

		public static PagamentoRequest CriarPagamento()
		{
			return new PagamentoRequest(TipoPagamento.DEBITO, 30.0);
		}
	}
}
