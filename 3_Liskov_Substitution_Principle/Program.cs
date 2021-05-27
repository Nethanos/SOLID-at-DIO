using _3_Liskov_Substitution_Principle.MathExample;
using LiskovSubstitutionExample;
using Newtonsoft.Json;
using System;

namespace _3_Liskov_Substitution_Principle
{
	class Program
	{
		static void Main(string[] args)
		{
			LiskovMathExemplo();
			
		}

		public static void LiskovPagamentoExemplo()
		{
			RealizarPagamento realizarPagamento = new RealizarPagamento();

			Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamento());


			Console.WriteLine(comprovante.AlertarPorEmail());
		
		}

		public static void LiskovMathExemplo()
		{


			S o1 = new S();

			T o2 = new T();


			if (o2.Andar() == "Andando")
			{
				Console.WriteLine("Sistema Funciona");
			}

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
