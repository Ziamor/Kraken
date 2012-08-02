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
        internal List<Component> components;

        public Component(GameScreen parent)
        {
            this.parent = parent;
            components = new List<Component>();
        }

        public GameScreen Parent
        {
            get { return parent; }
        }

        public virtual void Update(GameTime gameTime)
        {
            foreach (Component component in components)
                component.Update(gameTime);
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (Component component in components)
                component.Draw(gameTime, spriteBatch);
        }
    }
}
