using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Overlord
{
    class Line
    {
        private Point point0;
        private Point point1;
        private Mink mink;

        public Line(Vector2 point0, Vector2 point1)
        {
            this.point0 = new Point(point0);
            this.point1 = new Point(point1);

            this.mink = new Mink(Textures.GetTexture("100100circle"), point0, point1);
        }

        public void Draw(SpriteBatch sb)
        {
            point0.Draw(sb);
            point1.Draw(sb);

            sb.Draw(Textures.GetTexture("pinkSquare"), mink.minkedRectangle, null, Color.White, mink.minkedAngleFromRight, new Vector2(0, Textures.GetTexture("100100circle").Width/2), SpriteEffects.None, 0.5f);
        }
    }
}