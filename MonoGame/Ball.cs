using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
	public class Ball : GameObject
    {
		public Vector2 screenSize;

		public void Move( GameTime gameTime )
		{
			float deltaT = ( ( float ) gameTime.ElapsedGameTime.TotalMilliseconds * 0.001f );
			position += velocity * deltaT;

			if( position.Y < 0.0f || position.Y + texture.Bounds.Height > screenSize.Y )
				velocity.Y *= -1.0f;

			if( position.X < 0.0f || position.X + texture.Bounds.Width > screenSize.X )
				velocity.X *= -1.0f;
		}
	}
}
