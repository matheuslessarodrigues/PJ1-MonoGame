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

		public bool deveDesenhar = true;
		public double contadorTempo = 0.0;

		public void Load( ContentManager content )
		{
			texture = content.Load<Texture2D>( "PokemonSprite" );
		}

		public void Update( GameTime gameTime )
		{
			contadorTempo += gameTime.ElapsedGameTime.TotalMilliseconds;
			if( contadorTempo > 100.0 )
			{
				if( deveDesenhar )
					deveDesenhar = false;
				else
					deveDesenhar = true;
				contadorTempo = 0.0;
			}
		}

		public void Draw( SpriteBatch spriteBatch )
		{
			if( deveDesenhar )
			{
				spriteBatch.Draw( texture, position, color );
			}
		}
	}
}
