using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib.Interfaces
{
    public interface IContentLoadable
    {
        /// <summary>
        /// Load the objects content
        /// </summary>
        void LoadContent(ContentManager content);
    }
}
