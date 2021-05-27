using System.Runtime.Serialization;

namespace ModeloPagamento.src
{
	public enum TipoPagamento
	{
		[EnumMember(Value = "Debito")]
		DEBITO,
		[EnumMember(Value = "Credito")]
		CREDITO
	}
}
