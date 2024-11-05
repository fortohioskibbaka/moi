using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace moi
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;



        Texture2D dino;
        Texture2D gun;
        Texture2D bet;

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
            _graphics.PreferredBackBufferHeight = 600;

            _graphics.ApplyChanges();

            this.Window.Title = "i hope patrick mahomie dies ";

            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            dino = Content.Load<Texture2D>("dino");
            gun = Content.Load<Texture2D>("gun");
            bet = Content.Load<Texture2D>("bet");


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
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(dino, new Vector2(10, 10), Color.White);

            _spriteBatch.Draw(dino, new Vector2(500, 300), Color.MediumVioletRed);

            _spriteBatch.Draw(gun, new Vector2(500, 100), Color.MediumVioletRed);

            _spriteBatch.Draw(bet, new Vector2(300, 400), Color.MediumVioletRed);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
