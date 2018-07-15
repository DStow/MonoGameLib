using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib.Interfaces
{
    public interface IFontManager : IInitializable, IContentLoadable
    {
        SpriteFont GetFont(string fontKey);
    }
}
