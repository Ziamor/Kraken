using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kraken.GameScreens
{
    public class GameScreen
    {
        public bool BlocksDraw { get; set; }
        public bool BlocksUpdate { get; set; }
        internal List<Component> components;


        public GameScreen()
        {
            components = new List<Component>();
            LoadContent();
        }

        public List<Component> Components
        {
            get { return components; }
        }

        public virtual void LoadContent()
        {

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
