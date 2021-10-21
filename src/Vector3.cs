using System;

namespace CaveGame
{
	public class Vector3
	{
		public float X, Y, Z;

		public Vector3()
		{
			Zero();
		}

		public Vector3(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		public Vector3 Zero()
		{
			return new Vector3(0,0,0);
		}

		public void Copy(Vector3 vector)
		{
			this.X = vector.X;
			this.Y = vector.Y;
			this.Z = vector.Z;
		}

		public void SetAll(float number)
		{
			this.X = number;
			this.Y = number;
			this.Z = number;
		}

		public override string ToString()
		{
			return (
				"{" + 
					$"X:{X}" + 
					$" Y:{Y}" +
					$" Z:{Z}" +
				"}"
			);
		}
	}
}