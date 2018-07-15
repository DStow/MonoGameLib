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
    /// <summary>
    /// Series of values representing the physical properties of an object
    /// </summary>
    public class Transform
    {
        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; }
        public float Rotation { get; set; }
        public Anchor Anchor { get; set; }
        public float Scale { get; set; }

        public Transform()
        {
            Position = new Vector2();
            Size = new Vector2();
            Rotation = 0f;
            Anchor = new Anchor();
            Scale = 1f;
        }

        public Vector2 Origin(Texture2D texture)
        {
            return new Vector2(texture.Width * Anchor.X, texture.Height * Anchor.Y);
        }
    }

    public class Anchor
    {
        private Vector2 _anchor = new Vector2();

        public Anchor(float x, float y)
        {
            if (x < 0 || x > 1)
            {
                throw new AnchorValueOutOfBoundsException();
            }
            else if (y < 0 || y > 1)
            {
                throw new AnchorValueOutOfBoundsException();
            }
            else
            {
                _anchor = new Vector2(x, y);
            }
        }

        public Anchor()
        {
            _anchor = new Vector2(0, 0);
        }

        public float X
        {
            get { return _anchor.X; }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new AnchorValueOutOfBoundsException();
                }
                else
                {
                    _anchor = new Vector2(value, _anchor.Y);
                }
            }
        }

        public float Y
        {
            get { return _anchor.Y; }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new AnchorValueOutOfBoundsException();
                }
                else
                {
                    _anchor = new Vector2(_anchor.X, value);
                }
            }
        }

        public static implicit operator Vector2(Anchor anchor) { return new Vector2(anchor.X, anchor.X); }

        public class AnchorValueOutOfBoundsException : ApplicationException
        {
            public AnchorValueOutOfBoundsException()
                : base("The X and Y value for an anchor must be between 0 and 1")
            {

            }
        }
    }
}
