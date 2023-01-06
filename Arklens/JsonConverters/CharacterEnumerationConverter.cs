using BlazorSite3.Arklens.Core;
using BlazorSite3.Arklens.Core.CharacterElements;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorSite3.Arklens.JsonConverters;

public class CharacterEnumerationConverter : JsonConverterFactory
{
	public override bool CanConvert(Type typeToConvert)
		=> typeToConvert.GetInterfaces()
		.Any(i => i == typeof(ICharacterElementEnumeration<>));

	public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
	{
		throw new NotImplementedException();
	}

	private class CharacterEnumerationConverterInner<TElement> : JsonConverter<TElement>
		where TElement: CharacterElement, ICharacterElementEnumeration<TElement>
	{
		public override TElement? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			=> TElement.All.GetByName(reader.GetString()!);

		public override void Write(Utf8JsonWriter writer, TElement value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}
}
