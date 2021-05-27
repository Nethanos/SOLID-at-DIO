using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace ModeloPagamento.src
{
	public class Comprovante
	{

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
