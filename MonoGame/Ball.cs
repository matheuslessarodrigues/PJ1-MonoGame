using Microsoft.Xna.Framework;

namespace MonoGame
{
	public class Ball
	{
		public Vector2 position;
		public Vector2 velocity;

		public void Move()
		{
			position += velocity;
		}

		public void Draw()
		{

		}
	}
}
