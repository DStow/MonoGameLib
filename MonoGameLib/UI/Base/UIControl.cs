using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLib.UI.Base
{
    public abstract class UIControl : Interfaces.IUIControl
    {
        public bool Visible { get; set; }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
           
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
    }
}
