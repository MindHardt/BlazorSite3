using BlazorSite3.Arklens.Core.CharacterElements;

namespace BlazorSite3.Arklens.Models.Classes.Subclasses;

public class WizardSchool : Subclass, ICharacterElementEnumeration<WizardSchool>
{
	private WizardSchool(string emoji, string name) : base(emoji, name)
	{
	}

	/// <summary>
	/// The school of universal wizards.
	/// </summary>
	public static WizardSchool Universalist { get; } = new("🧙‍", "Универсалист");
	/// <summary>
	/// The school of animating souls and the spirit.
	/// </summary>
	public static WizardSchool Animaturg { get; } = new("👻", "Аниматург");
	/// <summary>
	/// The school of illusions and cantrips.
	/// </summary>
	public static WizardSchool Illusionist { get; } = new("👁‍", "Иллюзионист");
	/// <summary>
	/// The school of elements and destruction.
	/// </summary>
	public static WizardSchool Disruptor { get; } = new("💥", "Дизраптор");
	/// <summary>
	/// The school of processing and shaping.
	/// </summary>
	public static WizardSchool Transmutator { get; } = new("🔁", "Трансмутатор");
	/// <summary>
	/// The school of energy and transferring.
	/// </summary>
	public static WizardSchool Relocator { get; } = new("💫", "Релокатор");
	/// <summary>
	/// The school of foresight and prophecy.
	/// </summary>
	public static WizardSchool Seer { get; } = new("🔮", "Провидец");

	public static new IReadOnlyList<WizardSchool> All { get; } = new[] { Universalist, Animaturg, Illusionist, Disruptor, Transmutator, Relocator, Seer };

	public override IReadOnlySet<Alignment>? AlighmentRestrictions => null;
}
