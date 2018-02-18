using System;
using NStack;

namespace Terminal.Gui
{
    public static class Terminal
    {
        public static MenuBar MenuBar(params MenuBarItem[] menus)
            => new Gui.MenuBar(menus);

        public static MenuBarItem MenuBarItem(ustring title, params MenuItem[] children)
            => new Gui.MenuBarItem(title, children);

        public static MenuItem MenuItem(ustring title, string help = "", Action action = null)
            => new Gui.MenuItem(title, help, action);
    }
}