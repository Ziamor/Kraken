using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Kraken.GameScreens.Components;

namespace Kraken.GameScreens.Screens
{
    public class MainMenu : MenuScreen
    {
        public MainMenu()
            : base()
        {
            components.Add(new BackGround(this));
        }
    }
}
