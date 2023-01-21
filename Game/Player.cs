using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Client.Game;

public class Player : DrawableEntity
{
	private Texture2D _sprite;
	public Vector3 Velocity { get; set; } = Vector3.Zero;
	public Vector2 Position { get; set; } = Vector2.Zero;

	public Player(Microsoft.Xna.Framework.Game game) : base(game)
	{
		
	}

	protected override void LoadContent()
	{
		var content = Game.Content;

		_sprite = content.Load<Texture2D>("Textures/Player");

		base.LoadContent();
	}

	public override void Update(GameTime gameTime)
	{


		base.Update(gameTime);
	}

	public override void Draw(GameTime gameTime)
	{
		spriteBatch.Begin();
		spriteBatch.Draw(_sprite, new Rectangle(0, 0, 40, 60), Color.White);
		spriteBatch.End();

		base.Draw(gameTime);
	}
}