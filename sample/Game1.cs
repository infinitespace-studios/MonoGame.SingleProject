public class Game1 : Game {
    private GraphicsDeviceManager graphics;
    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        //if (Keyboard.GetState ().IsKeyDown (Keys.Escape))
        //    Exit ();
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear (Color.CornflowerBlue);
        base.Draw(gameTime);
    }
}