using BlazorSite3.Arklens.Core.CharacterElements;

namespace BlazorSite3.Arklens.Models.Stats;

public class Stat : CharacterElement
{
	public Stat(string name, string emoji) : base(name, emoji)
	{
	}

	/// <summary>
	/// The raw 1..20 value of stat, unaffected by effects.
	/// </summary>
	public int RawValue { get; set; }
	/// <summary>
	/// The raw -5..+5 modifyer, unaffected by effects.
	/// </summary>
	public int RawModifyer => RawValue / 2 + 5;
}
