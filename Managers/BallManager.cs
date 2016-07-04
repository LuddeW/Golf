using Golf.GameObjects;
using Golf.GameObjects.Tiles;
using Golf.Map;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf.Managers
{
    class BallManager
    {
        Ball player1Ball;
        Ball player2Ball;
        List<Ball> balls;

        public BallManager()
        {
            balls = new List<Ball>();
        }

        public void LoadContent(Vector2 ballStartPos)
        {
            player1Ball = new Ball(TextureLibrary.player1Ball, ballStartPos);
            player2Ball = new Ball(TextureLibrary.player2Ball, ballStartPos);
            balls.Add(player1Ball);
            balls.Add(player2Ball);
        }

        public void Update()
        {
            foreach (Tile tile in Grid.tiles)
            {
                if (player1Ball.hitbox.Intersects(tile.hitbox))
                {
                    player1Ball.pos.Y -= 1;
                }
                if (player1Ball.hitbox.Intersects(tile.hitbox))
                {
                    player2Ball.pos.Y -= 1;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                player1Ball.pos.Y -= 2;
                player1Ball.pos.X += 2;
            }
            player1Ball.Update();
            player2Ball.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Ball ball in balls)
            {
                ball.Draw(spriteBatch);
            }
        }
    }
}
