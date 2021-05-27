using System.Runtime.Serialization;

namespace SingleResponsabilityPrinciple
{
	public enum TipoPagamento
	{
		[EnumMember(Value = "Debito")]
		DEBITO,
		[EnumMember(Value = "Credito")]
		CREDITO
	}
}
