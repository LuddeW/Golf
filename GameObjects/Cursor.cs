using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf.GameObjects
{
    class Cursor : GameObject
    {
        private Vector2 offset;
        public Cursor(Texture2D texture, Vector2 pos) : base(texture, pos)
        {
            offset = new Vector2(10, 10);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, pos - offset, Color.White);
        }
    }
}
