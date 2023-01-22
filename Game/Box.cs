using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Client.Game;

class Box : DrawableEntity
{
	private Texture2D _texture;
	public Box(Microsoft.Xna.Framework.Game game) : base(game)
	{

	}

	protected override void LoadContent()
	{
		_texture = Game.Content.Load<Texture2D>("Textures/Box");

		base.LoadContent();
	}

	public override void Draw(GameTime gameTime)
	{
		spriteBatch.Begin(transformMatrix: Game1.GetCamera(Game).Transform);
		spriteBatch.Draw(_texture, new Rectangle(0, 0, 40, 40), Color.White);
		spriteBatch.End();

		base.Draw(gameTime);
	}
}