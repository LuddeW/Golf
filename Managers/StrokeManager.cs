using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf.Managers
{
    class StrokeManager
    {
        KeyboardState currentKeyboard;
        KeyboardState oldKeyboard;
        CursorManager cursorManager;
        BallManager ballManager;
        public StrokeManager(CursorManager cursorManager, BallManager ballManager)
        {
            this.cursorManager = cursorManager;
            this.ballManager = ballManager;
        }

        public void Update()
        {
            oldKeyboard = currentKeyboard;
            currentKeyboard = Keyboard.GetState();
            if (currentKeyboard.IsKeyDown(Keys.RightControl) && !oldKeyboard.IsKeyDown(Keys.RightControl))
            {
                ballManager.player1Ball.velocity.X = (cursorManager.player1Cursor.pos.X - ballManager.player1Ball.pos.X) / 100;
                ballManager.player1Ball.velocity.Y = (-cursorManager.player1Cursor.pos.Y / 100 - ballManager.player1Ball.pos.Y) / 100;
            }
            if (currentKeyboard.IsKeyDown(Keys.LeftControl) && !oldKeyboard.IsKeyDown(Keys.LeftControl))
            {
                ballManager.player2Ball.velocity.X = (cursorManager.player2Cursor.pos.X - ballManager.player2Ball.pos.X) / 100;
                ballManager.player2Ball.velocity.Y = (-cursorManager.player2Cursor.pos.Y / 100 - ballManager.player2Ball.pos.Y) / 100;
            }
        }
    }
}
