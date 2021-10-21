using System;

namespace CaveGame
{
	public class Vector2
	{
		public float X, Y;

		public Vector2()
		{
			Zero();
		}

		public Vector2(float X, float Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public Vector2 Zero()
		{
			return new Vector2(0,0);
		}

		public void Copy(Vector2 vector)
		{
			this.X = vector.X;
			this.Y = vector.Y;
		}

		public void SetAll(float number)
		{
			this.X = number;
			this.Y = number;
		}

		public override string ToString()
		{
			return (
				"{" + 
					$"X:{X}" + 
					$" Y:{Y}" +
				"}"
			);
		}
	}
}