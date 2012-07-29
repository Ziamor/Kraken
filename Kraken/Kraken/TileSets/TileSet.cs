using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kraken.TileSets
{
    public class TileSet
    {
        private Texture2D tileSetTex;           //TileSet image
        private int size;
        private int tileWidthCount;             //Amount of seperate tiles horizontally
        private int tileHeightCount;            //Amount of seperate tiles vertically
        private List<Rectangle> tiles;          //Rectangle list to split up the tileset into seperate tiles

        public TileSet(Texture2D tileSetTex)
        {
            this.tileSetTex = tileSetTex;
            this.tileWidthCount = tileSetTex.Width / 32;
            this.tileHeightCount = tileSetTex.Height / 32;
            this.tiles = new List<Rectangle>();
            this.size = 32;
            SplitTileSet();
        }
        public Texture2D TileSetTexture
        {
            get { return tileSetTex; }
        }

        public Rectangle GetTileAt(int index)
        {
            if (index > 0)
                return tiles[index - 1];
            else
                return tiles[0];
        }

        private void SplitTileSet()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = this.size;
            rectangle.Height = this.size;
            this.tiles.Clear();

            for (int y = 0; y < tileHeightCount; y++)
                for (int x = 0; x < tileWidthCount; x++)
                {
                    rectangle.X = x * this.size;
                    rectangle.Y = y * this.size;

                    this.tiles.Add(rectangle);
                }
        }
    }
}
