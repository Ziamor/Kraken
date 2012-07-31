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
        private static Stack<GameScreen> gameScreens;
        private static SpriteBatch spriteBatch;
        public static ContentManager contentManager;
        public static GraphicsDevice grahicsDevice;

        public GameScreenManager(Game game)
            : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            gameScreens = new Stack<GameScreen>();
            contentManager = (ContentManager)game.Services.GetService(typeof(ContentManager));
            grahicsDevice = (GraphicsDevice)game.Services.GetService(typeof(GraphicsDevice));
        }

        public Stack<GameScreen> GameScreens
        {
            get { return gameScreens; }
        }

        public SpriteBatch SpriteBatch
        {
            get { return spriteBatch; }
        }

        public static void AddScreen(GameScreen gameScreen)
        {
            gameScreens.Push(gameScreen);
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
