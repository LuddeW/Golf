using Golf.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf.Managers
{
    class CursorManager
    {
        private Cursor player1Cursor;
        private Cursor player2Cursor;
        List<Cursor> cursors = new List<Cursor>();

        public CursorManager()
        {           
            
        }

        public void Load()
        {
            player1Cursor = new Cursor(TextureLibrary.player1Cursor, new Vector2(100, 100));
            player2Cursor = new Cursor(TextureLibrary.player2Cursor, new Vector2(300, 300));
            cursors.Add(player1Cursor);
            cursors.Add(player2Cursor);
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Cursor cursor in cursors)
            {
                cursor.Draw(spriteBatch);
            }
        }
    }
}
