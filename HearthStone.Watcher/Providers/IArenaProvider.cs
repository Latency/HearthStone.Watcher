using HearthStone.Mirror.Objects;


namespace HearthStone.Watcher.Providers
{
	public interface IArenaProvider
	{
		ArenaInfo GetArenaInfo();
		Card[] GetDraftChoices();
	}
}
