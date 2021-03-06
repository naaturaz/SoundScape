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


namespace SoundScape
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class HelpScene : GameScene
    {
        private Texture2D texture;

        public HelpScene(Game game)
            : base(game, (game as Game1).SpriteBatch)
        {
            texture = game.Content.Load<Texture2D>("helpImage");
            this.Compontents.Add(new Bat(game, game.Content.Load<Texture2D>("Bat")));
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spritebatch.Begin();
            spritebatch.Draw(texture, Vector2.Zero, Color.White);
            spritebatch.End();
            base.Draw(gameTime);
        }
    }
}
