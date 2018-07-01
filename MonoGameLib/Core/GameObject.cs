using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLib.Core
{
    public class GameObject : Interfaces.IInitializable, Interfaces.IContentLoadable, Interfaces.IDrawable, Interfaces.IUpdatable
    {
        /// <summary>
        /// Position of this object
        /// </summary>
        public Vector2 Position { get; set; }

        /// <summary>
        /// Size of this object
        /// </summary>
        public Vector2 Size { get; set; }

        /// <summary>
        /// Area of this objects
        /// </summary>
        public RectangleF Area
        {
            get
            {
                return new RectangleF(Position.X - (Size.X / 2), Position.Y - (Size.Y / 2), Size.X, Size.Y);
            }
        }

        /// <summary>
        /// Rotation
        /// </summary>
        public float Rotation { get; set; }

        public virtual Vector2 Origin
        {
            get;
        }

        public virtual void Initialize()
        {

        }

        public virtual void LoadContent(ContentManager content)
        {

        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }

        protected virtual void DrawObjectTexture(SpriteBatch spriteBatch, Texture2D texture)
        {
            spriteBatch.Draw(texture, Area, null, Color.White, Rotation, Origin, SpriteEffects.None, 1);
        }
    }
}
