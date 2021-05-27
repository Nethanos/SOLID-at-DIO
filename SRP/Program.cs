using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SRP.SimpleExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP
{
	public class Program
	{
		public static void Main(string[] args)
		{

			RealizarPagamento realizarPagamento = new RealizarPagamento();

			Comprovante comprovante = realizarPagamento.PagamentoEmDebito(10.0);

			Console.WriteLine(comprovante);
		}

	}
}
