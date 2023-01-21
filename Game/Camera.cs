using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Client.Game;

public class Camera
{
	private Game1 _game;

	public Vector2 Position { get; set; }
	public Vector2 Rotation { get; set; }
	public Rectangle Bounds { get; protected set; }
	public Rectangle VisibleArea { get; set; }
	public Matrix Transform { get; protected set; }

	public Camera(Game1 game)
	{
		_game = game;
		Bounds = game.GraphicsDevice.Viewport.Bounds;
		Position = Vector2.Zero;
	}

	private void UpdateMatrix()
	{
		Transform = Matrix.CreateTranslation(new Vector3(-Position.X, -Position.Y, 0)) *
			Matrix.CreateScale(1f) *
			Matrix.CreateTranslation(new Vector3(Bounds.Width * 0.5f, Bounds.Height * 0.5f, 0));
	}

	public void MoveCamera(Vector2 moveVector)
	{
		Position += moveVector;
	}

	public void Update(Viewport viewport) 
	{
		Bounds = viewport.Bounds;
	}
}