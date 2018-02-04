using HearthStone.Mirror.Objects;


namespace HearthStone.Watcher.EventArgs
{
	public class CardPickedEventArgs : System.EventArgs
	{
		public Card Picked { get; }
		public Card[] Choices { get; }

		public CardPickedEventArgs(Card picked, Card[] choices)
		{
			Picked = picked;
			Choices = choices;
		}
	}
}
