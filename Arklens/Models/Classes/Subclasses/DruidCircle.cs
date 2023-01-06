using BlazorSite3.Arklens.Core.CharacterElements;

namespace BlazorSite3.Arklens.Models.Classes.Subclasses;

public class DruidCircle : Subclass, ICharacterElementEnumeration<DruidCircle>
{
	private DruidCircle(string emoji, string name) : base(emoji, name)
	{
	}

	/// <summary>
	/// The circle of flora and vegetation.
	/// </summary>
	public static DruidCircle Florilyth { get; } = new("🌿", "Флорилит");
	/// <summary>
	/// The circle of animals and beasts.
	/// </summary>
	public static DruidCircle Zoolyth { get; } = new("🦌", "Зоолит");
	/// <summary>
	/// The circle of insects and vermin.
	/// </summary>
	public static DruidCircle Ethnolyth { get; } = new("🦂", "Этнолит");
	/// <summary>
	/// The circle of death and decay.
	/// </summary>
	public static DruidCircle Decalyth { get; } = new("🍖", "Декалит");
	/// <summary>
	/// The circle of fungi and mold.
	/// </summary>
	public static DruidCircle Micolyth { get; } = new("🍄", "Миколит");

	public static new IReadOnlyList<DruidCircle> All { get; } = new[] { Florilyth, Zoolyth, Ethnolyth, Decalyth, Micolyth };

	public override IReadOnlySet<Alignment>? AlighmentRestrictions => null;
}
