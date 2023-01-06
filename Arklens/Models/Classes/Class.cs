using BlazorSite3.Arklens.Core.CharacterElements;
using BlazorSite3.Arklens.Models.Classes.Subclasses;
using BlazorSite3.Arklens.Models.Stats;

namespace BlazorSite3.Arklens.Models.Classes;

/// <summary>
/// A base class for <see cref="Character"/> classes (professions)
/// </summary>
public abstract class Class : CharacterElement
{
	/// <summary>
	/// The amount of class skillpoints of this <see cref="Class"/>.
	/// </summary>
	public abstract int SkillPoints { get; }

	/// <summary>
	/// The amount of health gained per level.
	/// </summary>
	public abstract int HealthGain { get; }

	/// <summary>
	/// The list of 6 <see cref="Type"/> objects which refer 
	/// to 6 <see cref="Stats.Stat"/> child classes, ordered from 
	/// highest to lowest priority.
	/// </summary>
	public abstract IReadOnlyList<Type> StatsPriority { get; }

	/// <summary>
	/// The list of <see cref="Type"/> objects which refer to
	/// <see cref="Skills.Skill"/> child classes, these skills
	/// are considered favored by this <see cref="Class"/>.
	/// </summary>
	public abstract IReadOnlySet<Type> FavoredSkills { get; }

	/// <summary>
	/// The <see cref="IReadOnlySet{T}"/> of allowed <see cref="Alignment"/>s
	/// or <see langword="null"/> if any <see cref="Alignment"/> is allowed.
	/// </summary>
	public abstract IReadOnlySet<Alignment>? AlighmentRestrictions { get; }
	/// <summary>
	/// Contains allowed <see cref="Subclass"/>es for this <see cref="Class"/>
	/// or <see langword="null"/> if class has no subclasses.
	/// </summary>
	public abstract IReadOnlyList<Subclass>? Subclasses { get; }

	protected Class(string name, string emoji) : base(name, emoji)
	{
	}

	/// <summary>
	/// Generates <see cref="IReadOnlyList{T}"/> of <see cref="Type"/>
	/// from provided generic types. throws <see cref="ArgumentException"/> if
	/// provided generic types duplicate.
	/// </summary>
	/// <typeparam name="S1"></typeparam>
	/// <typeparam name="S2"></typeparam>
	/// <typeparam name="S3"></typeparam>
	/// <typeparam name="S4"></typeparam>
	/// <typeparam name="S5"></typeparam>
	/// <typeparam name="S6"></typeparam>
	/// <returns></returns>
	/// <exception cref="ArgumentException"></exception>
	protected static IReadOnlyList<Type> GenerateStatsPriority<S1, S2, S3, S4, S5, S6>()
		where S1 : Stat
		where S2 : Stat
		where S3 : Stat
		where S4 : Stat
		where S5 : Stat
		where S6 : Stat
	{
		Type[] stats = new[]
		{
			typeof(S1), typeof(S2), typeof(S3),
			typeof(S4), typeof(S5), typeof(S6)
		};

		if (stats.Distinct().Count() < 6)
			throw new ArgumentException("Stats priority must be 6 different stats.");

		return stats;
	}
}
