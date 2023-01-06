using BlazorSite3.Arklens.Core.CharacterElements;
using System.Reflection;

namespace BlazorSite3.Arklens.Models.Classes.Subclasses;

public abstract class Subclass : CharacterElement, ICharacterElementEnumeration<Subclass>
{
	protected Subclass(string name, string emoji) : base(name, emoji)
	{

	}

	/// <summary>
	/// The <see cref="IReadOnlySet{T}"/> of allowed <see cref="Alignment"/>s
	/// or <see langword="null"/> if any <see cref="Alignment"/> is allowed.
	/// </summary>
	public abstract IReadOnlySet<Alignment>? AlighmentRestrictions { get; }

	public static IReadOnlyList<Subclass> All { get; } = GetAllSubclasses();
	
	private static IReadOnlyList<Subclass> GetAllSubclasses()
		=> Assembly.GetAssembly(typeof(Subclass))!
		.GetTypes()
		.Where(t => t.IsSubclassOf(typeof(Subclass)))
		.SelectMany(t => (IEnumerable<Subclass>)t.GetProperty(nameof(All))!.GetValue(null, null)!)
		.ToList();
}
