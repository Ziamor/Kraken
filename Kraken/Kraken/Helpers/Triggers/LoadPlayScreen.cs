using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kraken.Helpers;
using Kraken.GameScreens.Screens;
using Kraken.GameScreens;

namespace Kraken.Helpers.Triggers
{
    public class LoadPlayScreen : Trigger
    {
        public bool Fire()
        {
                GameScreenManager.AddScreen(new PlayMenu());
                return true;
        }
    }
}
