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
        private BallManager ballManager;
        
        public GameManager(ContentManager Content, Game1 game)
        {
            grid = new Grid();
            cursorManager = new CursorManager();
            ballManager = new BallManager(cursorManager);
        }

        public void LoadContent()
        {
            grid.CreateGrid();
            cursorManager.Load();
            ballManager.Load(grid.ballStartPos);
        }

        public void Update()
        {
            cursorManager.Update();
            ballManager.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Tile tile in Grid.tiles)
            {
                tile.Draw(spriteBatch);
            }
            ballManager.Draw(spriteBatch);
            cursorManager.Draw(spriteBatch);
        }
    }
}
