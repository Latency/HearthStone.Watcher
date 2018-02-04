using System.Collections.Generic;
using HearthStone.Mirror.Objects;


namespace HearthStone.Watcher.EventArgs
{
	public class PackEventArgs : System.EventArgs
	{
		public PackEventArgs(List<Card> cards, int packId)
		{
			Cards = cards;
			PackId = packId;
		}

		public List<Card> Cards { get; }
		public int PackId { get; set; }
	}
}
