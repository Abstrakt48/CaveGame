using System;

namespace CaveGame
{
	public class Player
	{
		private Vector2 position = new Vector2();

		public Player(Vector2 position)
		{
			// Copy the position parameter values to this.position vector
			this.position.Copy(position);
		}
	}
}