namespace HearthStone.Watcher.EventArgs
{
	public class FriendlyChallengeEventArgs : System.EventArgs
	{
		public bool DialogVisible { get; set; }

		public FriendlyChallengeEventArgs(bool dialogVisible)
		{
			DialogVisible = dialogVisible;
		}
	}
}
