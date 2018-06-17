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
                return new RectangleF(Position, Size);
            }
        }

        public void Initialize()
        {

        }

        public void LoadContent(ContentManager content)
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
