namespace BlazorSite3.Arklens.Core.CharacterElements;

/// <summary>
/// A base class for character elements with name and emoji
/// </summary>
public abstract class CharacterElement : IEquatable<CharacterElement>
{
    /// <summary>
    /// The text name of this <see cref="CharacterElement"/>.
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// The emoji name of this <see cref="CharacterElement"/>.
    /// </summary>
    public string Emoji { get; }

    public CharacterElement(string name, string emoji)
    {
        Name = name;
        Emoji = emoji;
    }

    public override bool Equals(object? obj)
        => ReferenceEquals(this, obj)
     || obj is CharacterElement other
     && other.Emoji == Emoji
     && other.Name == Name;

    public override int GetHashCode()
        => HashCode.Combine(Name, Emoji);

    /// <summary>
    /// Returns string representation of this <see cref="CharacterElement"/>.
    /// </summary>
    /// <returns>
    /// A string containing both <see cref="Emoji"/> and <see cref="Name"/>.
    /// </returns>
    public override string ToString()
        => $"{Emoji} {Name}";

    public bool Equals(CharacterElement? other)
        => Equals(this, other);

    public static bool operator ==(CharacterElement? left, CharacterElement? right)
        => Equals(left, right);

    public static bool operator !=(CharacterElement? left, CharacterElement? right)
        => !Equals(left, right);
}

