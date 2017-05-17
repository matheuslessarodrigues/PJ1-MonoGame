using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
	public class Player
	{
		public Vector2 position = new Vector2( 0.0f, 0.0f );
		public Vector2 velocity = new Vector2( 100.0f, 100.0f );

		public Texture2D texture;
		public Color color = new Color( 1.0f, 1.0f, 1.0f, 1.0f );

		public void Load( ContentManager content )
		{
			texture = content.Load<Texture2D>( "PokemonSprite" );
		}

		public void Move( GameTime gameTime )
		{
			
		}

		public void Draw( SpriteBatch spriteBatch )
		{
			spriteBatch.Draw( texture, position, color );
		}
	}
}
