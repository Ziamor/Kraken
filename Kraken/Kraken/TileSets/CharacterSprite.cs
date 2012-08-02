using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kraken.TileSets
{
    public class CharacterSprite
    {
        private TileSet tileSet;

        public CharacterSprite(Texture2D characterTex)
        {
            this.tileSet = new TileSets.TileSet(characterTex);;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tileSet.TileSetTexture,Vector2.Zero, tileSet.GetTileAt(1), Color.White);
        }
    }
}
