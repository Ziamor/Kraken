using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Kraken.Helpers;

namespace Kraken.GameScreens.Map
{
    public class Sprite
    {
        protected Rectangle bounds; // Bounding box for the sprite
        protected Vector2 position; // Position of the sprite
        protected Vector2 velocity; // Velocity sprite is moving
        protected Vector2 correction; // Correction vector if colliding
        protected Texture2D texture; // Texture for the sprite
        protected bool isSolid = false; // Is the sprite solid
        protected bool isCollided;

        private VerticalDirection verticalDirection = new VerticalDirection();
        private HorizontalDirection horizontalDirection = new HorizontalDirection();

        public Rectangle Bounds
        {
            get { return bounds; }
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Vector2 Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public Vector2 Correction
        {
            get { return correction; }
        }

        public bool IsSolid
        {
            get { return isSolid; }
            set { isSolid = value; }
        }

        public bool IsCollided
        {
            get { return isCollided; }
            set { isCollided = value; }
        }

        public bool IsCollidingWith(Sprite sprite)
        {
            if (this.Bounds.Intersects(sprite.Bounds))
                return true;
            return false;
        }

        public Rectangle GetBounds()
        {
            if (texture != null)
                bounds = new Rectangle((int)Position.X, (int)Position.Y, texture.Width, texture.Height);
            return bounds;
        }

        public List<Sprite> GetCollision(List<Sprite> sprites)
        {
            List<Sprite> collisions = new List<Sprite>();
            correction = Vector2.Zero;
            this.IsCollided = false;
            GetBounds();

            foreach (Sprite sprite in sprites)
                if (sprite.IsSolid && this.IsCollidingWith(sprite))
                {

                    // The sprite is colliding
                    this.IsCollided = true;
                    collisions.Add(sprite);

                    // Gets the centers
                    Point center = this.bounds.Center;
                    Point spriteCenter = sprite.bounds.Center;
                    velocity = Vector2.Zero;

                    // Get the horizontal direction
                    if (center.X < spriteCenter.X)
                        horizontalDirection = HorizontalDirection.Left;
                    else if (center.X > spriteCenter.X)
                        horizontalDirection = HorizontalDirection.Right;
                    else
                        horizontalDirection = HorizontalDirection.Equal;
                    // Gets the vertical direction
                    if (center.Y < spriteCenter.Y)
                        verticalDirection = VerticalDirection.Up;
                    else if (center.Y > spriteCenter.Y)
                        verticalDirection = VerticalDirection.Below;
                    else
                        verticalDirection = VerticalDirection.Equal;

                    correction.X += (int)horizontalDirection;
                    correction.Y += (int)verticalDirection;
                }

            if (correction.X < 0)
                correction.X = (int)HorizontalDirection.Left;
            else if (correction.X > 0)
                correction.X = (int)HorizontalDirection.Right;
            else
                correction.X = (int)HorizontalDirection.Equal;

            if (correction.Y < 0)
                correction.Y = (int)VerticalDirection.Up;
            else if (correction.Y > 0)
                correction.Y = (int)VerticalDirection.Below;
            else
                correction.Y = (int)VerticalDirection.Equal;
            position += correction;
            return collisions;
        }

        public void CollisionResolve(List<Sprite> sprites)
        {
            int count = 32;
            List<Sprite> collidedSprites = sprites;

            while (this.isCollided)
            {
                collidedSprites = GetCollision(collidedSprites);
                count--;
            }
        }
    }
}
