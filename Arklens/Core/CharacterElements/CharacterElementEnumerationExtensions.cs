using BlazorSite3.Arklens.Core.CharacterElements;

namespace BlazorSite3.Arklens.Core;

public static class CharacterElementExtensions
{
	/// <summary>
	/// Gets <typeparamref name="TSelf"/> with <see cref="CharacterElement.Name"/>
	/// equal to <paramref name="name"/> or <see langword="null"/> if none is found
	/// in <paramref name="collection"/>.
	/// </summary>
	/// <param name="name"></param>
	/// <returns></returns>
	public static TElement? GetByName<TElement>(this IEnumerable<TElement> collection, string? name)
		where TElement : CharacterElement
		=> collection.FirstOrDefault(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
}
