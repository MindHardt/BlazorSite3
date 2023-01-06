namespace BlazorSite3.Arklens.Core.Throws.Buffs;

/// <summary>
/// Defines <see cref="Buff"/>s behaviour on apply depending on its value.
/// </summary>
public readonly record struct BuffApplyBehaviour
{
	/// <summary>
	/// Defines the behaviour when <see cref="Buff.Amount"/> is positive.
	/// </summary>
	public SummaryType Positive { get; }
	/// <summary>
	/// Defines the behaviour when <see cref="Buff.Amount"/> is negative.
	/// </summary>
	public SummaryType Negative { get; }

	public BuffApplyBehaviour(SummaryType positive, SummaryType negative)
	{
		Positive = Enum.IsDefined(positive) ? 
			positive : 
			throw new ArgumentOutOfRangeException(nameof(positive));
		Negative = Enum.IsDefined(negative) ?
			negative :
			throw new ArgumentOutOfRangeException(nameof(negative)); ;
	}

	/// <summary>
	/// The default value for <see cref="BuffApplyBehaviour"/>.
	/// With this option, only strongest positive <see cref="Buff"/> takes place,
	/// while all negative <see cref="Buff"/>s are summarized.
	/// </summary>
	public static BuffApplyBehaviour Default => new(SummaryType.Compare, SummaryType.AddToSum);

	public enum SummaryType : byte
	{
		AddToSum = 0x00,
		Compare = 0xFF,
	}
}
