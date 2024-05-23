using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame_Assignment_2
{
    public class Game1 : Game
    {


        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circleTexture;
        Texture2D rectangleTexture;
        SpriteFont titleFont;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            titleFont = Content.Load<SpriteFont>("TitleFont");
            // TODO: use this.Content to load your game content here
            

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();

            
            GraphicsDevice.Clear(Color.MediumPurple);
            _spriteBatch.Draw(circleTexture, new Rectangle(190, 100, 120, 95), Color.Pink);
            _spriteBatch.Draw(circleTexture, new Rectangle(390, 100, 120, 95), Color.Pink);
            _spriteBatch.Draw(circleTexture, new Rectangle(300, 0, 90, 120), Color.Pink);
            _spriteBatch.Draw(circleTexture, new Rectangle(300, 175, 90, 120), Color.Pink);
            _spriteBatch.Draw(circleTexture, new Rectangle(300, 100, 100, 100), Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(340, 290, 20, 400), Color.LawnGreen);
            _spriteBatch.DrawString(titleFont, "Flower", new Vector2(10, 10), Color.Yellow);
            // TODO: Add your drawing code here
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
//