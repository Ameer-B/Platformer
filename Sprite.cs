using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    public abstract class Sprite
    {
        public Vector2 Location { get; set; }
        public Vector2 Size { get; set; }
        public Texture2D Texture { get; set; }
        public Vector2 Speed;


        protected Sprite(Vector2 location, Vector2 size, Texture2D texture, Vector2 speed)
        {
            Location = location;
            Size = size;
            Texture = texture;
            Speed = speed;
        }

        public abstract void Update(GameTime gameTime, KeyboardState KeyState, Viewport Viewport);

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
