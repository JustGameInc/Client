﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Client;

public class Game1 : Microsoft.Xna.Framework.Game
{
	private GraphicsDeviceManager _graphics;
	private SpriteBatch _spriteBatch;
	public Game.Camera Camera { get; private set; }
	public Game1 Game { get; private set; }

	public Game1()
	{
		_graphics = new GraphicsDeviceManager(this);
		Content.RootDirectory = "Content";
		IsMouseVisible = true;
		Window.AllowUserResizing = true;

		Components.Add(new Game.Player(this));

		Camera = new Game.Camera(this);
	}

	protected override void Initialize()
	{
		// TODO: Add your initialization logic here
		Window.Title = "Mega game";

		base.Initialize();
	}

	protected override void LoadContent()
	{
		_spriteBatch = new SpriteBatch(GraphicsDevice);

		base.LoadContent();
	}

	protected override void Update(GameTime gameTime)
	{
		if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
			Exit();

		Camera.Update(GraphicsDevice.Viewport);

		base.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		GraphicsDevice.Clear(Color.CornflowerBlue);

		base.Draw(gameTime);
	}
}
