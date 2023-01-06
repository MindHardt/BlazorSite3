using BlazorSite3.Arklens.Core.CharacterElements;
using BlazorSite3.Arklens.Models.Classes;

namespace BlazorSite3.Arklens.Models;

public class CharacterDraft
{
	public string? Name { get; set; }

	public CharacterElementData<Class> Class { get; } = new();

	public string? AlignmentName { get; set; }
	public Alignment? Alignment { get; }

	public string? Race { get; set; }
}
