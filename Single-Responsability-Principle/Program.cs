using Newtonsoft.Json;
using SingleResponsabilityPrinciple;
using System;
using System.Text.Json;

namespace Single_Responsability_Principle
{
	class Program
	{
		static void Main(string[] args)
		{


			RealizarPagamento realizarPagamento = new RealizarPagamento();

			Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamento());

			Console.WriteLine(JsonConvert.SerializeObject(comprovante));
		}

		public static PagamentoRequest CriarPagamento()
		{
			return new PagamentoRequest(TipoPagamento.CREDITO, 30.0);
		}
	}
}


	
