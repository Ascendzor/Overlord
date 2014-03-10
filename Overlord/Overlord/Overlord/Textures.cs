using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Overlord
{
    class Textures
    {
        private static Dictionary<string, Texture2D> textures;

        public static void Initialize(ContentManager cm)
        {
            textures = new Dictionary<string, Texture2D>();
            
            textures.Add("100100circle", cm.Load<Texture2D>("100100circle"));
            textures.Add("pinkSquare", cm.Load<Texture2D>("pinkSquare"));
        }

        public static Texture2D GetTexture(string textureKey)
        {
            return textures[textureKey];
        }
    }
}
