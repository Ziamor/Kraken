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
        string imagePath;

        public BackGround(GameScreen parent, string imagePath)
            : base(parent)
        {
            this.imagePath = imagePath;
            backgroundImage = GameScreenManager.contentManager.Load<Texture2D>(imagePath);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(backgroundImage, Vector2.Zero, Color.White);
            base.Draw(gameTime, spriteBatch);
        }
    }
}
