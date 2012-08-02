using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Kraken.GameScreens.Map
{
    public class Tile : Sprite
    {
        private int id;

        public Tile(int ID, Vector2 position)
        {
            this.id = ID;
            this.position = position;
            this.bounds = new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public int ID
        {
            get { return id; }
        }

        public void Update(GameTime gameTime)
        {
            this.bounds = new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }
    }
}
