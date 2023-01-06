using System.Text.Json.Serialization;

namespace BlazorSite3.Arklens.Core.CharacterElements;

/// <summary>
/// A helper class for <see cref="Models.CharacterDraft"/> assisting with
/// JSON serialization and selecting.
/// </summary>
public class CharacterElementData<TElement>
	where TElement : CharacterElement, ICharacterElementEnumeration<TElement>
{
	private string? _name;

	/// <summary>
	/// The serialized name of the <see cref="Element"/>.
	/// If changed, <see cref="Element"/> also changes.
	/// </summary>
	public string? Name 
	{ 
		get => _name; 
		set
		{
			_name = value;
			UpdateElement();
		}
	}

	/// <summary>
	/// The actial non-serialized value.
	/// </summary>
	[JsonIgnore]
	public TElement? Element { get; private set; }

	private void UpdateElement() => Element = TElement.All.GetByName(_name);
}
