using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Kraken.TileSets;

namespace Kraken.GameScreens.Map
{
    public class MapItem : Component
    {
        int[,] map = {
                     {1,1,1,1},
                     {1,0,0,1},
                     {1,0,0,1},
                     {1,1,1,1},
                     };
        private TileSet tileSet;
        private Texture2D tilesetTexture;

        public MapItem(GameScreen parent)
            : base(parent)
        {
            tilesetTexture = GameScreenManager.contentManager.Load<Texture2D>("Images//TileSheet");
            tileSet = new TileSet(tilesetTexture);
        }

        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            for (int i = 0; i < map.GetLength(0); i++)
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Tile tile;
                    if (map[i, j] == 1)
                        tile = new Tile(0, new Vector2(i * 32, j * 32));
                    else
                        tile = new Tile(1, new Vector2(i * 32, j * 32));
                    spriteBatch.Draw(tileSet.TileSetTexture, tile.Position,tileSet.GetTileAt(tile.ID), Color.White);
                }
            base.Draw(gameTime, spriteBatch);
        }
    }
}
