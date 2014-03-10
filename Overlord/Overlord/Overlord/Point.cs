using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Overlord
{
    class Point
    {
        private Vector2 position;

        public Point(Vector2 position)
        {
            this.position = position;
        }

        public void Draw(SpriteBatch sb)
        {
            Texture2D circle = Textures.GetTexture("100100circle");
            Vector2 centeredCircle = new Vector2(position.X - circle.Width / 2, position.Y - circle.Height / 2);
            sb.Draw(circle, centeredCircle, Color.White);
        }

        public Vector2 GetPosition()
        {
            return position;
        }
    }
}
