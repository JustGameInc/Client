using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Client.Game;

public class Player : DrawableEntity
{
	public Vector2 Position { get; set; } = Vector2.Zero;

	public Player(Microsoft.Xna.Framework.Game game) : base(game)
	{
		
	}
}