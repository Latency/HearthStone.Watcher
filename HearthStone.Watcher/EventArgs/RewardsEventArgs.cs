using HearthStone.Mirror.Objects;


namespace HearthStone.Watcher.EventArgs
{
	public class RewardsEventArgs : System.EventArgs
	{
		public ArenaInfo Info { get; set; }

		public RewardsEventArgs(ArenaInfo info)
		{
			Info = info;
		}
	}
}
