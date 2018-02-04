using HearthStone.Mirror.Objects;


namespace HearthStone.Watcher.EventArgs
{
	public class ChoicesChangedEventArgs : System.EventArgs
	{
		public Card[] Choices { get; }
		public Deck Deck { get; }

		public ChoicesChangedEventArgs(Card[] choices, Deck deck)
		{
			Choices = choices;
			Deck = deck;
		}
	}
}
