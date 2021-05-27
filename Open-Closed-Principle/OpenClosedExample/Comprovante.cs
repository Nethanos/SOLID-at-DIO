
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace OpenClosedPrinciple
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

		public string AlertarPorEmail()
		{
			return $"O usuario {usuarioLogado} realizou o pagamento no valor de {valor} utilizando a forma de pagamento {tipoPagamento}.";
		}
	}
}
