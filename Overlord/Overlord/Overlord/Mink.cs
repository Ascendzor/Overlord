using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Overlord
{
    class Mink
    {
        public Rectangle minkedRectangle;
        public float minkedAngleFromRight;

        public Mink(Texture2D shape, Vector2 point0, Vector2 point1)
        {
            Vector2 directionOfLine = point1 - point0;
            directionOfLine.Normalize();

            minkedAngleFromRight = (float)Math.Atan2(directionOfLine.X, directionOfLine.Y);

            Texture2D playersTexture = Textures.GetTexture("100100circle");
            int widthOfRectangle = (int)Vector2.Distance(point0, point1);
            minkedRectangle = new Rectangle((int)point0.X, (int)point0.Y, widthOfRectangle, playersTexture.Width);
        }
    }
}
