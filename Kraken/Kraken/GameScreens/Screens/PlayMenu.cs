using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kraken.GameScreens.Components;
using Kraken.GameScreens.Map;
using Kraken.GameScreens.Screens.ScreenHelpers;
using Microsoft.Xna.Framework;

namespace Kraken.GameScreens.Screens
{
    public class PlayMenu : GameScreen
    {
        public PlayMenu()
        {
            components.Add(new BackGround(this, "Images//BackGround//background-test2"));
            this.BlocksUpdate = true;
            this.BlocksDraw = true;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
        }
    }
}
