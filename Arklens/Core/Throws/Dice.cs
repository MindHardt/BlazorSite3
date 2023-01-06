namespace BlazorSite3.Arklens.Core.Throws;

public abstract class Dice
{
	public virtual int Minimum { get; } = 1;
	public abstract int Maximum { get; }
	public abstract int Throw();
}
