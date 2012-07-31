using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kraken.GameScreens
{
    public class Component
    {
        private GameScreen parent;

        public Component(GameScreen parent)
        {
            this.parent = parent;
        }

        public GameScreen Parent
        {
            get { return parent; }
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

        }
    }
}
