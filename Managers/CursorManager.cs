using Golf.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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
            Player1MoveCursor();
            Player2MoveCursor();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Cursor cursor in cursors)
            {
                cursor.Draw(spriteBatch);
            }
        }

        private void Player1MoveCursor()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                player1Cursor.pos.Y -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                player1Cursor.pos.Y += 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                player1Cursor.pos.X -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                player1Cursor.pos.X += 2;
            }
        }
        private void Player2MoveCursor()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                player2Cursor.pos.Y -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                player2Cursor.pos.Y += 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                player2Cursor.pos.X -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                player2Cursor.pos.X += 2;
            }
        }
    }
}
