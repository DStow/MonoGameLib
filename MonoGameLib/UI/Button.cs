using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib.UI
{
    public class Button : Base.UIControl
    {
        public SpriteFont Font { get; set; }
        public string Text { get; set; }

        // ToDo: Replace this with a decent anchoring system
        public Vector2 Position { get; set; }
        public Color Color { get; set; }

        private string backgroundContentKey = "";
        public Texture2D Background { get; set; }

        public Button(SpriteFont font, string text, string backgroundContentKey)
        {
            this.Font = font;
            this.Text = text;
            this.backgroundContentKey = backgroundContentKey;
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);

            Background = content.Load<Texture2D>(backgroundContentKey);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
