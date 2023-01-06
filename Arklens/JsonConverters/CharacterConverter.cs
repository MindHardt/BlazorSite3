using BlazorSite3.Arklens.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorSite3.Arklens.JsonConverters;

public class CharacterConverter : JsonConverter<Character>
{
	public override Character? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		throw new NotImplementedException();
	}

	public override void Write(Utf8JsonWriter writer, Character value, JsonSerializerOptions options)
	{
		throw new NotImplementedException();
	}
}
