using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kraken.GameScreens.Components;

namespace Kraken.GameScreens.Screens
{
    public class MenuList : Component
    {
        List<MenuText> menuTexts;

        public MenuList(GameScreen parent)
            : base(parent)
        {
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
    }
}
