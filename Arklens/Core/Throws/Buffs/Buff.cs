namespace BlazorSite3.Arklens.Core.Throws.Buffs;

public class Buff
{
    /// <summary>
    /// Represents <see cref="Buff"/>s source, or origin.
    /// By default, only the strongest <see cref="Buff"/>
    /// of the same non-<see langword="null"/> <see cref="Source"/> 
    /// affects throw, while <see langword="null"/>s 
    /// are considered unconditional.
    /// </summary>
    public string? Source { get; }
    /// <summary>
    /// The amount this <see cref="Buff"/> adds or substracts from the result
    /// of the throw.
    /// </summary>
    public int Amount { get; }
    public BuffApplyBehaviour ApplyBehaviour { get; }

	public Buff(string? source, int amount, BuffApplyBehaviour? applyBehaviour = null)
	{
		Source = source;
		Amount = amount;
		ApplyBehaviour = applyBehaviour ?? BuffApplyBehaviour.Default ;
	}
}
