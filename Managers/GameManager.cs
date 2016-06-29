using Golf.GameObjects;
using Golf.Map;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf.Managers
{
    class GameManager
    {
        private Grid grid;
        
        public GameManager(ContentManager Content, Game1 game)
        {
            grid = new Grid();
        }

        public void LoadContent()
        {
            grid.CreateGrid();
        }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (GameObject g in grid.gameObjects)
            {
                g.Draw(spriteBatch);
            }
        }
    }
}
