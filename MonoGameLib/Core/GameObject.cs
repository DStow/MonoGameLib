﻿using System;
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
        private Transform _tranform;

        public Transform Transform
        {
            get { return _tranform; }
            set { _tranform = value; }
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
            spriteBatch.Draw(texture, Transform.Position, null, Color.White, Transform.Rotation, Transform.Anchor, Transform.Scale, SpriteEffects.None, 1);
        }
    }
}
