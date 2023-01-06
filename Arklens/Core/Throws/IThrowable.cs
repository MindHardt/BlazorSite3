using BlazorSite3.Arklens.Core.Throws;

namespace BlazorSite3.Arklens.Core.Throwable;

public interface IThrowable
{
	public ThrowResult Throw(Dice dice);
}
