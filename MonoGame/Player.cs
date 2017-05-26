using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame
{
	public class Player
	{
		public Vector2 position = new Vector2( 0.0f, 100.0f );
		public Vector2 velocity = new Vector2( 100.0f, 100.0f );

		public Texture2D textureParado;
        public Texture2D[] texturesAndando;
        public Color color = new Color( 1.0f, 1.0f, 1.0f, 1.0f );

		public int indiceAnimacao = 0;
		public double contadorTempo = 0.0;

        public bool olhandoDireita;
        public bool estaAndando;

		public void Load( ContentManager content )
		{
			textureParado = content.Load<Texture2D>( "megaman1" );

            texturesAndando = new Texture2D[4];
            texturesAndando[0] = content.Load<Texture2D>("megaman3");
            texturesAndando[1] = content.Load<Texture2D>("megaman2");
            texturesAndando[2] = content.Load<Texture2D>("megaman3");
            texturesAndando[3] = content.Load<Texture2D>("megaman4");
        }

        public void TentaAtirar( Tiro tiro )
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                tiro.position = position;

                if( olhandoDireita )
                    tiro.velocity = new Vector2(1000.0f, 0.0f);
                else
                    tiro.velocity = new Vector2(-1000.0f, 0.0f);
            }
        }

		public void Update( GameTime gameTime )
		{
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                position.X += 4.0f;
                olhandoDireita = true;
                estaAndando = true;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                position.X -= 4.0f;
                olhandoDireita = false;
                estaAndando = true;
            }
            else
            {
                estaAndando = false;
            }

            contadorTempo += gameTime.ElapsedGameTime.TotalMilliseconds;
			if( contadorTempo > 300.0 )
			{
                indiceAnimacao += 1;
				if( indiceAnimacao == texturesAndando.Length )
					indiceAnimacao = 0;

				contadorTempo = 0.0;
			}
		}

		public void Draw( SpriteBatch spriteBatch )
		{
            SpriteEffects flip;
            if (olhandoDireita)
                flip = SpriteEffects.FlipHorizontally;
            else
                flip = SpriteEffects.None;

            Texture2D texture;
            if (estaAndando)
            {
                texture = texturesAndando[indiceAnimacao];
            }
            else
            {
                texture = textureParado;
            }

            spriteBatch.Draw(texture, position, null, color, 0.0f,
                Vector2.Zero, 5.0f, flip, 0.0f);
        }
	}
}
