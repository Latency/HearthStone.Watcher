using System.Collections.Generic;
using HearthStone.Mirror.Objects;


namespace HearthStone.Watcher.Providers
{
	public interface IPackProvider
	{
		List<Card> GetCards();
		int GetPackId();
	}
}
