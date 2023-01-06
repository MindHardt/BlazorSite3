namespace BlazorSite3.Arklens.Core.Throws;

public class ThrowResult
{
	public Dice Dice { get; }
	public IReadOnlySet<int> Throws { get; }
	public int EffectiveModifyer { get; }
	public int Sum { get; }

	public ThrowResult(Dice dice, int count, int effectiveModifyer)
	{
		Dice = dice;
		EffectiveModifyer = effectiveModifyer;
		Throws = Enumerable
			.Repeat(0, count)
			.Select(_ => Dice.Throw())
			.ToHashSet();
		Sum = Throws.Sum() + EffectiveModifyer;
	}
}
