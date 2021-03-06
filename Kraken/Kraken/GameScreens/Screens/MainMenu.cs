﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Kraken.GameScreens.Components;
using Kraken.GameScreens.Map;
using Kraken.GameScreens.Screens.ScreenHelpers;
using Kraken.GameScreens.Screens;
using Kraken.Helpers.Triggers;

namespace Kraken.GameScreens.Screens
{
    public class MainMenu : MenuScreen
    {
        private MenuList menuList;
        public MainMenu()
            : base()
        {
            menuList = new MenuList(this, new Vector2(100, 200));
            menuList.AddMenuText("Play!", new LoadPlayScreen());
            menuList.AddMenuText("Options");
            menuList.AddMenuText("Quit");

            components.Add(new BackGround(this, "Images//BackGround//background-test"));
            components.Add(menuList);
        }

        public override void Update(GameTime gameTime)
        {
            //Console.WriteLine("Updating main menu");
            base.Update(gameTime);
        }
    }
}
