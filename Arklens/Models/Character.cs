using BlazorSite3.Arklens.Models.Classes.Subclasses;
using BlazorSite3.Arklens.Models.Classes;

namespace BlazorSite3.Arklens.Models;

public class Character
{
	public required string Name { get; init; }
	public required Class Class { get; init; }
	public required Subclass? Subclass { get; init; }
	public required Alignment Alignment { get; init; }
}
