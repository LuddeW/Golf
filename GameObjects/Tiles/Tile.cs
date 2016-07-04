using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf.GameObjects.Tiles
{
    class Tile : GameObject
    {
        public Rectangle hitbox;
        public Tile(Texture2D texture, Vector2 pos) : base (texture, pos)
        {
            hitbox = new Rectangle((int)pos.X, (int)pos.Y, 20, 20);
        }
    }
}
