using Golf.GameObjects;
using Golf.GameObjects.Tiles;
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
        private CursorManager cursorManager;
        
        public GameManager(ContentManager Content, Game1 game)
        {
            grid = new Grid();
            cursorManager = new CursorManager();
        }

        public void LoadContent()
        {
            grid.CreateGrid();
            cursorManager.Load();
        }

        public void Update()
        {
            cursorManager.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Tile tile in grid.tiles)
            {
                tile.Draw(spriteBatch);
            }
            cursorManager.Draw(spriteBatch);
        }
    }
}
