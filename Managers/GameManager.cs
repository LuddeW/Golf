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
        public GameManager(ContentManager Content, Game1 game)
        {

        }

        public void LoadContent()
        {
          
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(TextureLibrary.green, new Rectangle(620, 300, 20, 20), Color.White);
            spriteBatch.Draw(TextureLibrary.green, new Rectangle(640, 300, 20, 20), Color.White);
            spriteBatch.Draw(TextureLibrary.green, new Rectangle(660, 300, 20, 20), Color.White);
            spriteBatch.Draw(TextureLibrary.cup, new Rectangle(680, 300, 20, 20), Color.White);
            spriteBatch.Draw(TextureLibrary.flagpost, new Rectangle(680, 280, 20, 20), Color.White);
            spriteBatch.Draw(TextureLibrary.flagpost, new Rectangle(680, 260, 20, 20), Color.White);
            spriteBatch.Draw(TextureLibrary.flag, new Rectangle(680, 240, 20, 20), Color.White);
            spriteBatch.Draw(TextureLibrary.green, new Rectangle(700, 300, 20, 20), Color.White);
            spriteBatch.Draw(TextureLibrary.green, new Rectangle(720, 300, 20, 20), Color.White);
            spriteBatch.Draw(TextureLibrary.player1Ball, new Rectangle(620, 290, 10, 10), Color.White);
        }
    }
}
