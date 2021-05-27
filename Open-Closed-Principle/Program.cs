using Newtonsoft.Json;
using OpenClosedPrinciple;
using System;

namespace Open_Closed_Principle
{
	class Program
	{
		static void Main(string[] args)
		{

			RealizarPagamento realizarPagamento = new RealizarPagamento();

			Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamentoCredito());

			//TODO: AJEITAR ESSE CONVERTER

			Console.WriteLine(JsonConvert.SerializeObject(comprovante));
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
