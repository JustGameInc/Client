using Microsoft.Xna.Framework;

namespace Client;

abstract class Entity 
{
	public virtual int Health { get; set; }

	public virtual void Update(GameTime gameTime) {}
	public virtual void Draw(GameTime gameTime) {}
}