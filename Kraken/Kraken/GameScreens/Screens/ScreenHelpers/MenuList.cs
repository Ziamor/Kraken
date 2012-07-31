using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Kraken.GameScreens.Components;

namespace Kraken.GameScreens.Screens.ScreenHelpers
{
    public class MenuList : Component
    {
        List<MenuText> menuTexts;
        SpriteFont font;
        private Vector2 pos;
        private int index;

        public MenuList(GameScreen parent, Vector2 pos)
            : base(parent)
        {
            this.pos = pos;
            font = GameScreenManager.contentManager.Load<SpriteFont>("Font//MainMenuFont");
            menuTexts = new List<MenuText>();
            index = 0;
        }

        public Vector2 Position
        {
            get { return pos; }
            set { pos = value; }
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        internal void AddMenuText(MenuText menuText)
        {
            Parent.components.Add(menuText);
            menuTexts.Add(menuText);
        }

        internal void AddMenuText(string strText)
        {
            MenuText menuText = new MenuText(Parent);
            menuText.Text = strText;
            Parent.components.Add(menuText);
            menuTexts.Add(menuText);
        }

        internal void AddMenuText(string strText,GameScreen linkScreen)
        {
            MenuText menuText = new MenuText(Parent, linkScreen);
            menuText.Text = strText;
            Parent.components.Add(menuText);
            menuTexts.Add(menuText);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            for (int i = 0; i < menuTexts.Count; i++)
            {
                MenuText txt = menuTexts[i];
                Vector2 pos = new Vector2();
                Color color;

                if (i == index)
                    color = Color.GreenYellow;
                else
                    color = Color.White;
                pos.X = this.pos.X;
                pos.Y = font.LineSpacing * i + this.pos.Y;
                txt.Position = pos;
                spriteBatch.DrawString(font, txt.Text, txt.Position, color);
            }
            base.Draw(gameTime, spriteBatch);
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState();
            if (InputHandler.GetState(Keys.S) == InputState.Pressed || InputHandler.GetState(Keys.Down) == InputState.Pressed)
                index++;
            else if (InputHandler.GetState(Keys.W) == InputState.Pressed || InputHandler.GetState(Keys.Up) == InputState.Pressed)
                index--;
            if (index < 0)
                index = menuTexts.Count - 1;
            else if (index > menuTexts.Count - 1)
                index = 0;
            if (InputHandler.GetState(Keys.Enter) == InputState.Pressed)
            {
                if (index < menuTexts.Count && index >= 0)
                {
                    MenuText menuText = menuTexts[index];
                    if (menuText != null)
                        menuText.OnClick();
                }
            }
            base.Update(gameTime);
        }
    }
}
