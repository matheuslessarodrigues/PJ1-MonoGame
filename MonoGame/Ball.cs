using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
	public class Ball
	{
		public Vector2 screenSize;

		public Vector2 position = new Vector2( 0.0f, 0.0f );
		public Vector2 velocity = new Vector2( 100.0f, 100.0f );

		public Texture2D texture;
		public Color color = new Color( 1.0f, 1.0f, 1.0f, 1.0f );

		public void Load( ContentManager content )
		{
			texture = content.Load<Texture2D>( "BallSprite" );
		}

		public void Move( GameTime gameTime )
		{
			position += velocity * ( ( float ) gameTime.ElapsedGameTime.TotalMilliseconds * 0.001f );

			if( position.Y < 0.0f || position.Y + texture.Bounds.Height > screenSize.Y )
				velocity.Y *= -1.0f;

			if( position.X < 0.0f || position.X + texture.Bounds.Width > screenSize.X )
				velocity.X *= -1.0f;
		}

		public void Draw( SpriteBatch spriteBatch )
		{
			spriteBatch.Draw( texture, position, color );
		}
	}
}
