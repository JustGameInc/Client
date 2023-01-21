using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Client.Game;

public abstract class Entity : GameComponent
{
	protected SpriteBatch spriteBatch;
	public Entity(Microsoft.Xna.Framework.Game game) : base(game) 
	{

	}

	~Entity() {}
}

public abstract class DrawableEntity : DrawableGameComponent
{
	protected SpriteBatch spriteBatch;
	public DrawableEntity(Microsoft.Xna.Framework.Game game) : base(game) 
	{

	}

	protected override void LoadContent()
	{
		spriteBatch = new SpriteBatch(GraphicsDevice);

		base.LoadContent();
	}

	~DrawableEntity() {}
}