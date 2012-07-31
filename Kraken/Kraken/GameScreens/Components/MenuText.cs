using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kraken.GameScreens.Components
{
    public class MenuText : Component
    {
        private string text;
        private Vector2 pos;

        private GameScreen loadScreen;

        public MenuText(GameScreen parent)
            : base(parent)
        {
        }

        public Vector2 Position
        {
            get { return pos; }
            set { pos = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public bool OnClick()
        {
            return false;
        }
    }
}
