using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SingleResponsabilityPrinciple
{
	public class Comprovante
	{


		public string usuarioLogado { get; set; }

		public Comprovante(string descricao, string valor, TipoPagamento tipoPagamento)
		{
			this.descricao = descricao;
			this.valor = valor;
			this.tipoPagamento = tipoPagamento;
		}

		public string descricao { get; set; }

		public string valor { get; set; }

		[JsonConverter(typeof(StringEnumConverter))]
		public TipoPagamento tipoPagamento { get; set; }
	}
}
