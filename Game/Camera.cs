using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Client.Game;

public class Camera : GameComponent
{

	public Vector2 Position { get; set; }
	public Vector2 Rotation { get; set; }
	public Rectangle Bounds { get; set; }
	public Rectangle VisibleArea { get; set; }
	public Matrix Transform { get; protected set; }

	public Camera(Microsoft.Xna.Framework.Game game) : base(game)
	{
		Position = Vector2.Zero;
	}

	public override void Initialize()
	{
		Bounds = Game.GraphicsDevice.Viewport.Bounds;
		base.Initialize();
	}

	public void UpdateMatrix()
	{
		Transform = Matrix.CreateTranslation(new Vector3(-Position.X, -Position.Y, 0)) *
			Matrix.CreateScale(1f) *
			Matrix.CreateTranslation(new Vector3(Bounds.Width * 0.5f, Bounds.Height * 0.5f, 0));
	}

	public void MoveCamera(Vector2 moveVector)
	{
		Position += moveVector;
	}

	public override void Update(GameTime gameTime)
	{
		UpdateMatrix();
	}
}