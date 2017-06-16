using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MonoGame
{
    public class World
    {
        private List<GameObject> objetos;
        private ContentManager content;

        public void InstantiateObject(GameObject gameObject)
        {
            objetos.Add(gameObject);
            gameObject.world = this;
            gameObject.Load(content);
        }

        public void LoadObjects(ContentManager contentManager)
        {
            objetos = new List<GameObject>();
            content = contentManager;

            InstantiateObject(new Ball());
            objetos[0].velocity = new Vector2(100.0f, 100.0f);

            InstantiateObject(new Tiro());
            objetos[1].scale = 0.1f;

            InstantiateObject(new Player());
            objetos[2].position = new Vector2(100.0f, 100.0f);

            InstantiateObject(new Ball());
            objetos[3].position = new Vector2(10, 10);
            objetos[3].scale = 1.0f;
        }

        public void UpdateObjects(GameTime gameTime)
        {
            for(int i = 0; i < objetos.Count; i++)
            {
                GameObject obj = objetos[i];
                obj.Update(gameTime);
            }
        }

        public void DrawObjects(SpriteBatch spriteBatch)
        {
            foreach (GameObject obj in objetos)
            {
                obj.Draw(spriteBatch);
            }
        }
    }
}
