using HearthStone.Mirror.Objects;


namespace HearthStone.Watcher.EventArgs
{
	public class CompleteDeckEventArgs : System.EventArgs
	{
		public ArenaInfo Info { get; set; }

		public CompleteDeckEventArgs(ArenaInfo info)
		{
			Info = info;
		}
	}
}
