using System;

namespace CaveGame
{
	public class Game
	{
		// Player variables
		private Vector2 playerPosition;
		private Player player;

		public Game()
		{
			playerPosition = new Vector2(10,10);
			player = new Player(playerPosition);
		}
	}
}