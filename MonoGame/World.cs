using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MonoGame
{
    public class World
    {
        private List<GameObject> gameObjects;
        private ContentManager content;

        public void InstantiateObject(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
            gameObject.world = this;
            gameObject.Load(content);
        }

        public void LoadObjects(ContentManager contentManager)
        {
            gameObjects = new List<GameObject>();
            content = contentManager;

            InstantiateObject(new Ball());
            gameObjects[0].velocity = new Vector2(100.0f, 100.0f);

			Ball ball = new Ball();
			InstantiateObject( ball );
			gameObjects[1].position = new Vector2( 10, 10 );

			InstantiateObject(new Tiro());
            gameObjects[2].scale = 0.1f;

			Player player = new Player();
			player.ball = ball;
            InstantiateObject(player);
            gameObjects[3].position = new Vector2(100.0f, 100.0f);
        }

        public void UpdateObjects(GameTime gameTime)
        {
            for(int i = 0; i < gameObjects.Count; i++)
            {
                GameObject obj = gameObjects[i];
                obj.Update(gameTime);
            }
        }

        public void DrawObjects(SpriteBatch spriteBatch)
        {
            foreach (GameObject obj in gameObjects)
            {
                obj.Draw(spriteBatch);
            }
        }
    }
}
