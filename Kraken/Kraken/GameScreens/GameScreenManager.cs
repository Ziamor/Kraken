using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Kraken.GameScreens
{
    public class GameScreenManager : DrawableGameComponent
    {
        private Stack<GameScreen> gameScreens;
        private SpriteBatch spriteBatch;
        public static ContentManager contentManager;
        public static GraphicsDeviceManager graphics;

        public GameScreenManager(Game game)
            : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            gameScreens = new Stack<GameScreen>();
            contentManager = (ContentManager)game.Services.GetService(typeof(ContentManager));
            graphics = (GraphicsDeviceManager)game.Services.GetService(typeof(GraphicsDeviceManager));
        }

        public Stack<GameScreen> GameScreens
        {
            get { return gameScreens; }
        }

        public SpriteBatch SpriteBatch
        {
            get { return spriteBatch; }
        }

        public override void Update(GameTime gameTime)
        {
            Stack<GameScreen> screensToUpdate = new Stack<GameScreen>();
            foreach (GameScreen gameScreen in GameScreens)
            {
                screensToUpdate.Push(gameScreen);
                if (gameScreen.BlocksUpdate)
                    break;
            }
            foreach (GameScreen gameScreen in screensToUpdate)
                gameScreen.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            Stack<GameScreen> screensToDraw = new Stack<GameScreen>();
            foreach (GameScreen gameScreen in GameScreens)
            {
                screensToDraw.Push(gameScreen);
                if (gameScreen.BlocksDraw)
                    break;
            }
            foreach (GameScreen gameScreen in screensToDraw)
                gameScreen.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }
    }
}
