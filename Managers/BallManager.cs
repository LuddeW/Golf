﻿using Golf.GameObjects;
using Golf.GameObjects.Tiles;
using Golf.Map;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
                foreach (Ball ball in balls)
                {
                    ball.Update();
                    if (ball.hitbox.Intersects(tile.hitbox))
                    {
                        //ball.pos.Y += 1;
                    }
                }
            }
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
