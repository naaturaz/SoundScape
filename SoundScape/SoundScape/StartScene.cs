using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using XNALib.Scenes;
using XNALib.Menus;


namespace SoundScape
{
    public class StartScene : GameScene
    {
        private SpriteFont regularFont, highlightFont;
        private MenuComponent menu;

        public int SelectedIndex
        {
            get { return menu.MenuIndex; }
        }

        public MenuItem SelectedItem
        {
            get { return menu.ActiveMenuItem; }
        }
        
        private Color regularColour = Color.Black;
        private Color highlightColor = Color.Red;
        private List<string> menuItems;

        public StartScene(Game game, SpriteBatch sb, string[] menuItems)
            : base(game, sb)
        {
            this.menuItems = menuItems.ToList();
            Initialize();
        }

        protected override void LoadContent()
        {
            regularFont = Game.Content.Load<SpriteFont>("SpriteFont1");
            highlightFont = Game.Content.Load<SpriteFont>("SpriteFont2");

            this.menu = new MenuComponent(Game, spritebatch, regularColour, highlightColor, regularFont, highlightFont, Vector2.Zero);
            foreach (string item in menuItems)
            {
                menu.Add(item, null);
            }
            this.Compontents.Add(menu);
            base.LoadContent();
        }
    }
}
