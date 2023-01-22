using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Client.Game;

public class LocalPlayer : Player
{
	private Texture2D _sprite;
	public Vector2 Velocity { get; set; } = Vector2.Zero;
	
	public Vector2 Speed { get; set; } = new Vector2(100f, 100f);
	public Vector2 MaxSpeed { get; set; } = new Vector2(1000f, 1000f);

	public LocalPlayer(Microsoft.Xna.Framework.Game game) : base(game)
	{

	}

	static public Vector2 NormalizeVelocity(Vector2 velocity, Vector2 maxVelocity, float deltaTime)
	{
		if (Math.Abs(velocity.X) > maxVelocity.X)
		{
			velocity.X -= Math.Sign(velocity.X) * (Math.Abs(velocity.X) - maxVelocity.X) * deltaTime;
		}
		
		if (Math.Abs(velocity.Y) > maxVelocity.Y)
		{
			velocity.Y -= Math.Sign(velocity.Y) * (Math.Abs(velocity.Y) - maxVelocity.Y) * deltaTime;
		}

		return velocity;
	}

	static public Vector2 SubstractVelocity(Vector2 velocity, float deltaTime, Vector2 speed)
	{
		velocity.X -= Math.Sign(velocity.X) * deltaTime * speed.X;
		velocity.Y -= Math.Sign(velocity.Y) * deltaTime * speed.Y;
		return velocity;
	}

	public override void Update(GameTime gameTime)
	{
		var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
		if (GamePad.GetState(PlayerIndex.One).DPad.Down == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.S))
			Velocity += Velocity.Y <= MaxSpeed.Y ? Vector2.UnitY * Speed.Y * delta : Vector2.Zero;
		if (GamePad.GetState(PlayerIndex.One).DPad.Up == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.W))
			Velocity -= Velocity.Y <= MaxSpeed.Y ? Vector2.UnitY * Speed.Y * delta : Vector2.Zero;
		if (GamePad.GetState(PlayerIndex.One).DPad.Right == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.D))
			Velocity += Velocity.X <= MaxSpeed.X ? Vector2.UnitX * Speed.X * delta : Vector2.Zero;
		if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.A))
			Velocity -= Velocity.X <= MaxSpeed.X ? Vector2.UnitX * Speed.X * delta : Vector2.Zero;
		

		Velocity = NormalizeVelocity(Velocity, MaxSpeed, delta);
		Position += Velocity;
		Velocity = SubstractVelocity(Velocity, delta, Speed);

		base.Update(gameTime);
	}

	protected override void LoadContent()
	{
		var content = Game.Content;
		_sprite = content.Load<Texture2D>("Textures/Player");
		base.LoadContent();
	}

	public override void Draw(GameTime gameTime)
	{
		spriteBatch.Begin();
		spriteBatch.Draw(_sprite, new Rectangle((int)Position.X, (int)Position.Y, 40, 60), Color.White);
		spriteBatch.End();

		base.Draw(gameTime);
	}
}