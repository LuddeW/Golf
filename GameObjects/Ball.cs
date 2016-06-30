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
        private Vector2 direction;
        private Vector2 speed;

        public Ball(Texture2D texture, Vector2 pos) : base(texture, pos)
        {
            offset = new Vector2(10, 10);
        }

        public void Update()
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, pos + offset, Color.White);
        }
    }
}
