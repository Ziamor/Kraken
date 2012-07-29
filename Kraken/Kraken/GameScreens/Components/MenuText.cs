using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kraken.GameScreens.Components
{
    public class MenuText : Component
    {
        private string text;

        public MenuText(GameScreen parent)
            : base(parent)
        {
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
