using System.Runtime.Serialization;

namespace OpenClosedPrinciple
{
	public enum TipoPagamento
	{
		[EnumMember(Value = "Debito")]
		DEBITO,
		[EnumMember(Value = "Credito")]
		CREDITO
	}
}
