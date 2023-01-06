using BlazorSite3.Arklens.Core.CharacterElements;
using System.Diagnostics.CodeAnalysis;

namespace BlazorSite3.Arklens.Models.Classes.Subclasses;

public class PriestFaith : Subclass, ICharacterElementEnumeration<PriestFaith>
{
	public Alignment DeityAlignment { get; }
	private PriestFaith(string name, string emoji, Alignment deityAlignment)
		: base(name, emoji)
	{
		DeityAlignment = deityAlignment;
		AlighmentRestrictions = Alignment.All
			.Where(a => a.DistanceTo(DeityAlignment) <= 1)
			.ToHashSet();
	}

	[NotNull]
	public override IReadOnlySet<Alignment> AlighmentRestrictions { get; }

	/// <summary>
	/// Faith in <see cref="Alignment.LawfulGood"/> deity Neras.
	/// </summary>
	public static PriestFaith Nerasith { get; } = new("⚒️", "Нерасит", Alignment.LawfulGood);
	/// <summary>
	/// Faith in <see cref="Alignment.NeutralGood"/> deity Sol.
	/// </summary>
	public static PriestFaith Solarith { get; } = new("🌞", "Солярит", Alignment.NeutralGood);
	/// <summary>
	/// Faith in <see cref="Alignment.ChaoticGood"/> deity Yunai.
	/// </summary>
	public static PriestFaith Yunaith { get; } = new("🌟", "Юнаит", Alignment.LawfulGood);

	/// <summary>
	/// Faith in <see cref="Alignment.LawfulNeutral"/> deity Avar.
	/// </summary>
	public static PriestFaith Avarith { get; } = new("⚔️", "Аварит", Alignment.LawfulNeutral);
	/// <summary>
	/// Faith in <see cref="Alignment.Neutral"/> deity Jastar.
	/// </summary>
	public static PriestFaith Jastarith { get; } = new("⚖️", "Джастарит", Alignment.Neutral);
	/// <summary>
	/// Faith in <see cref="Alignment.ChaoticNeutral"/> deity Morthiss.
	/// </summary>
	public static PriestFaith Morthith { get; } = new("💋", "Мортит", Alignment.ChaoticNeutral);

	/// <summary>
	/// Faith in <see cref="Alignment.LawfulEvil"/> deity Archivarius.
	/// </summary>
	public static PriestFaith Archivarith { get; } = new("💀", "Архиварит", Alignment.LawfulEvil);
	/// <summary>
	/// Faith in <see cref="Alignment.NeutralEvil"/> deity Asterio.
	/// </summary>
	public static PriestFaith Asterith { get; } = new("👑", "Астерит", Alignment.NeutralEvil);
	/// <summary>
	/// Faith in <see cref="Alignment.ChaoticEvil"/> deity Sangiz.
	/// </summary>
	public static PriestFaith Sangith { get; } = new("🦷", "Сангит", Alignment.ChaoticEvil);

	public static new IReadOnlyList<PriestFaith> All { get; } = new[] { Nerasith, Solarith, Yunaith, Avarith, Jastarith, Morthith, Archivarith, Asterith, Sangith };
}
