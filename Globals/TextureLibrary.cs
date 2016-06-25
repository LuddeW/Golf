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
        public static Texture2D cup;
        public static Texture2D flagpost;
        public static Texture2D flag;

        public static void LoadContent(ContentManager Content)
        {
            
            green = Content.Load<Texture2D>("Green");
            fairway = Content.Load<Texture2D>("Fairway");
            rough = Content.Load<Texture2D>("Rough");
            cup = Content.Load<Texture2D>("cup");
            flagpost = Content.Load<Texture2D>("flagpost");
            flag = Content.Load<Texture2D>("flag");
        }
    }    
}
