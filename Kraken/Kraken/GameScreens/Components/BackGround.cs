using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kraken.GameScreens.Components
{
    public class BackGround : Component
    {
        Texture2D backgroundImage;

        public BackGround(GameScreen parent)
            : base(parent)
        {

        }

        public override void LoadContent()
        {
            backgroundImage = GameScreenManager.contentManager.Load<Texture2D>("background-test");
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(backgroundImage, Vector2.Zero, Color.White);
            base.Draw(gameTime, spriteBatch);
        }
    }
}
