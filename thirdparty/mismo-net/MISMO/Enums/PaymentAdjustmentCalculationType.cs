using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for PaymentAdjustmentCalculationType.
	/// </summary>
	[Serializable()]
	public enum PaymentAdjustmentCalculationType : short
	{
		Undefined = 0,
		AddFixedDollarAmountToTheCurrentPayment = 1,
		AddPercentToCurrentPaymentAmount = 2,
		AddPercentToEffectivePaymentRate = 3
	}
}
