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
            if (currentKeyboard.IsKeyDown(Keys.Space) && !oldKeyboard.IsKeyDown(Keys.Space))
            {
                ballManager.player1Ball.velocity.X = cursorManager.player1Cursor.pos.X / 100;
                ballManager.player1Ball.velocity.Y = -cursorManager.player1Cursor.pos.Y / 100;
            }
        }
    }
}
