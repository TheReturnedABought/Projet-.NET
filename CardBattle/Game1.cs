using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using System;
using System.Collections.Generic;
namespace CardBattle;

public class Game1 : Core
{
    private Dictionary<string, Texture2D> cards = new Dictionary<string, Texture2D>();
    string[] family = { "clubs", "diamonds", "spades", "hearts"};
    string[] value = { "02", "03", "04", "05", "06", "07", "08", "09", "10", "ace", "jack", "king", "queen" };
    public Game1() : base("Bataile", 1280, 720, false)
    {

    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        foreach (string i in family) {
            foreach (string j in value){
                    cards[$"{i}_{j}"] = Content.Load<Texture2D>($"images/{i}/{i}_{j}");
                }
        }
        base.LoadContent();
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
        GraphicsDevice.Clear(Color.CornflowerBlue);
        SpriteBatch.Begin();

        SpriteBatch.Draw(cards["spades_02"], Vector2.Zero, Color.White);

        SpriteBatch.End();
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}

