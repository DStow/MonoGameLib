using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonoGameLib.Interfaces;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLib.Core
{
    public abstract class Scene : Interfaces.IScene
    {
        public List<object> GameObjects { get; set; }

        public virtual void Initialize()
        {
            GameObjects = new List<object>();
        }

        public virtual void LoadContent(ContentManager content)
        {
            foreach (object o in GameObjects)
            {
                IContentLoadable loadableObj = o as IContentLoadable;
                if (loadableObj != null)
                {
                    loadableObj.LoadContent(content);
                }
            }
        }

        public virtual void Update(GameTime gameTime)
        {
            foreach (object o in GameObjects)
            {
                IUpdatable updatableObj = o as IUpdatable;
                if (updatableObj != null)
                {
                    updatableObj.Update(gameTime);
                }
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            foreach (object o in GameObjects)
            {
                Interfaces.IDrawable drawableObj = o as Interfaces.IDrawable;
                if (drawableObj != null)
                {
                    drawableObj.Draw(spriteBatch);
                }
            }
        }
    }
}
