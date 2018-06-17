using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib.Interfaces
{
    public interface IUpdatable
    {
        /// <summary>
        /// Update the object
        /// </summary>
        void Update(GameTime gameTime);
    }
}
