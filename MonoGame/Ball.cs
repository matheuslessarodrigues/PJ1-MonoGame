using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
	public class Ball : GameObject
    {
		public Vector2 screenSize;

        public override void Load(ContentManager content)
        {
            animation.textures = new Texture2D[1];
            animation.textures[0] = content.Load<Texture2D>("BallSprite");
            scale = 1.0f;

			collider.size = new Vector2( 150.0f, 150.0f );
        }

        public override void Update( GameTime gameTime )
		{
			float deltaT = ( ( float ) gameTime.ElapsedGameTime.TotalMilliseconds * 0.001f );
			position += velocity * deltaT;

            /*
			if( position.Y < 0.0f || position.Y + texture.Bounds.Height > screenSize.Y )
				velocity.Y *= -1.0f;

			if( position.X < 0.0f || position.X + texture.Bounds.Width > screenSize.X )
				velocity.X *= -1.0f;
                */
		}
    }
}
