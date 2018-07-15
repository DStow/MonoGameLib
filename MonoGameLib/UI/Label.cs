using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLib.UI
{
    public class Label : Base.UIControl
    {
        public SpriteFont Font { get; set; }
        public string Text { get; set; }

        // ToDo: Replace this with a decent anchoring system
        public Vector2 Position { get; set; }
        public Color Color { get; set; }

        public Label(SpriteFont font, string text, Color color)
        {
            this.Font = font;
            this.Text = text;
            this.Color = color;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Font, Text, Position, Color);
        }

        public float GetLabelWidth()
        {
            return Font.MeasureString(Text).X;
        }
    }
}
