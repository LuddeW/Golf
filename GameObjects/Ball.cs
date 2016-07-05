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
        public Vector2 velocity;
        private float gravity;
        public Rectangle hitbox;

        public Ball(Texture2D texture, Vector2 pos) : base(texture, pos)
        {
            offset = new Vector2(10, 10);
            gravity = 0.0982f;
            velocity = new Vector2(0, 0);
            
        }

        public void Update()
        {
            velocity.Y += gravity;  
            if (velocity.X > 0)
            {
                velocity.X -= 0.05f;
            }
            if (velocity.X < 0.1 && velocity.X > 0)
            {
                velocity.X = 0;
            }
            pos.X += velocity.X;
            pos.Y += velocity.Y;
            hitbox = new Rectangle((int)pos.X + (int)offset.X, (int)pos.Y + (int)offset.Y, 10, 10);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, pos + offset, Color.White);
        }
    }
}
