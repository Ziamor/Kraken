using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Kraken.GameScreens.Screens;
using Kraken.Helpers;

namespace Kraken.GameScreens.Screens.ScreenHelpers
{
    public class MenuText : Component
    {
        private string text;
        private Vector2 pos;
        private Trigger trigger;

        public MenuText(GameScreen parent)
            : base(parent)
        {
        }

        public MenuText(GameScreen parent, Trigger trigger)
            : base(parent)
        {
            this.trigger = trigger;
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
            if (trigger != null)
                trigger.Fire();
            return false;
        }
    }
}
