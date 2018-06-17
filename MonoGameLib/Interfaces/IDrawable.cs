using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib.Interfaces
{
    public interface IDrawable
    {
        /// <summary>
        /// Draw the object
        /// </summary>
        void Draw(SpriteBatch spriteBatch);
    }
}
