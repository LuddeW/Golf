using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf.GameObjects
{
    class Ball : GameObject
    {
        private Vector2 offset;
        public Vector2 direction;
        public Vector2 velocity;
        private float gravity;
        public Rectangle hitbox;

        public Ball(Texture2D texture, Vector2 pos) : base(texture, pos)
        {
            offset = new Vector2(10, 10);
            gravity = 0.982f;
            
            
        }

        public void Update()
        {
            pos.Y += gravity;
            hitbox = new Rectangle((int)pos.X + (int)offset.X, (int)pos.Y + (int)offset.Y, 10, 10);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, pos + offset, Color.White);
        }
    }
}
