using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kraken.GameScreens.Map
{
    public class Map : Component
    {
        int[,] map = {
                     {1,1,1,1},
                     {1,0,0,1},
                     {1,0,0,1},
                     {1,1,1,1},
                     };        
        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            for (int i = 0; i < map.GetLength(0); i++)
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Color tileColor;
                    if (map[i, j] == 1)
                        tileColor = Color.Red;
                    else
                        tileColor = Color.White;
                    Texture2D tile = new Texture2D(GraphicsDevice,1,1);
                    spriteBatch.Draw(
                }
            base.Draw(gameTime, spriteBatch);
        }
    }
}
