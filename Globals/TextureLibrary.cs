using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golf
{
    class  TextureLibrary
    {        
        public static Texture2D green;
        public static Texture2D fairway;
        public static Texture2D rough;
        public static Texture2D bunker;
        public static Texture2D mud;
        public static Texture2D water;
        public static Texture2D stone;
        public static Texture2D cup;
        public static Texture2D flagpost;
        public static Texture2D flag;
        public static Texture2D player1Ball;
        public static Texture2D player2Ball;
        public static Texture2D player1Cursor;
        public static Texture2D player2Cursor;

        public static void LoadContent(ContentManager Content)
        {
            
            green = Content.Load<Texture2D>(@"Green");
            fairway = Content.Load<Texture2D>(@"Fairway");
            rough = Content.Load<Texture2D>(@"Rough");
            bunker = Content.Load < Texture2D>(@"bunker");
            mud = Content.Load<Texture2D>(@"mud");
            water = Content.Load<Texture2D>(@"water");
            stone = Content.Load<Texture2D>(@"stone");
            cup = Content.Load<Texture2D>(@"cup");
            flagpost = Content.Load<Texture2D>(@"flagpost");
            flag = Content.Load<Texture2D>(@"flag");
            player1Ball = Content.Load<Texture2D>(@"Player1Ball");
            player2Ball = Content.Load<Texture2D>(@"Player2Ball");
            player1Cursor = Content.Load<Texture2D>(@"Player1Cursor");
            player2Cursor = Content.Load<Texture2D>(@"Player2Cursor");
        }
    }    
}
