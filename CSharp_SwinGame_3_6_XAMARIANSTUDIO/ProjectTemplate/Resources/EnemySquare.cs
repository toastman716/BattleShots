using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class EnemySquare:Enemy
	{
		public EnemySquare ()
		{
		}

		public override void Draw() 
		{
			SwinGame.FillRectangle(Color.Red, X, Y, Size, Size);
		}

		public override bool IsAt(Point2D position)
		{
			return SwinGame.PointInRect (position, X, Y, Size, Size);
		}

		public override void Move()
		{
			if (Orientation == true)
				X += Speed;
			else
				X -= Speed;
		}
	}
}

