using Golf.GameObjects;
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
            foreach (Ball ball in balls)
            {
                ball.Update();
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
