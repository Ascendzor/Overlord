using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Overlord
{
    class Map
    {
        private static List<Line> lines;

        public static void Initialize()
        {
            Line line0 = new Line(new Vector2(100, 100), new Vector2(400, 400));

            lines = new List<Line>();
            lines.Add(line0);
        }

        public static void Draw(SpriteBatch sb)
        {
            foreach(Line line in lines)
            {
                line.Draw(sb);
            }
        }
    }
}
