namespace BlazorSite3.Arklens.Core.CharacterElements;

/// <summary>
/// Exposes a property containing all possible values.
/// If this interface is implemented no public ctors should exist.
/// </summary>
/// <typeparam name="TSelf"></typeparam>
public interface ICharacterElementEnumeration<TSelf>
    where TSelf : CharacterElement, ICharacterElementEnumeration<TSelf>
{
    /// <summary>
    /// All the values of <typeparamref name="TSelf"/>.
    /// </summary>
    public static abstract IReadOnlyList<TSelf> All { get; }

    /// <summary>
    /// Gets <typeparamref name="TSelf"/> with <see cref="CharacterElement.Name"/>
    /// equal to <paramref name="name"/> or <see langword="null"/> if none is found.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static TSelf? GetByName(string? name)
        => TSelf.All.FirstOrDefault(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

}
