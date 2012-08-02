using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kraken.GameScreens.Components;
using Kraken.GameScreens.Map;
using Kraken.GameScreens.Screens.ScreenHelpers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Kraken.GameScreens.Screens
{
    public class PlayMenu : GameScreen
    {
        private MapItem map;
        public PlayMenu()
        {
            map = new MapItem(this);
            components.Add(new BackGround(this, "Images//BackGround//background-test2"));
            components.Add(map);
            this.BlocksUpdate = true;
            this.BlocksDraw = true;
        }

        public override void Update(GameTime gameTime)
        {
            if (InputHandler.GetState(Keys.Back) == InputState.Pressed)
                GameScreenManager.RemoveScreen(this);
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
        }
    }
}
