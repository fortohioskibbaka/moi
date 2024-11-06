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
        Texture2D belk;
        Texture2D fort;
       Texture2D emac;
        Texture2D big;
        Texture2D mag;

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

            this.Window.Title = " first project ";

            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            dino = Content.Load<Texture2D>("dino");
            gun = Content.Load<Texture2D>("gun");
            bet = Content.Load<Texture2D>("bet");
            belk = Content.Load<Texture2D>("belk");
            fort = Content.Load<Texture2D>("fort");
            emac = Content.Load<Texture2D>("emac");
            big= Content.Load<Texture2D>("big");

            mag = Content.Load<Texture2D>("mag");


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
            _spriteBatch.Draw(fort, new Vector2(0, 0), Color.White);
           

            

            _spriteBatch.Draw(gun, new Vector2(500, 100), Color.White);

            
            _spriteBatch.Draw(belk, new Vector2(350, 200), Color.White);

            _spriteBatch.Draw(emac, new Vector2(550, 200), Color.White);

            _spriteBatch.Draw(big , new Vector2(100, 200), Color.White);
            _spriteBatch.Draw(mag, new Vector2(650, 250), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
