using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class Player:Entity
	{

		public Player ()
		{
			Size = 15;
		}

		public override void Draw() 
		{
			SwinGame.FillCircle(Color.Blue, X, Y, Size);
		}

		public override bool IsAt(Point2D position)
		{
			return SwinGame.PointInCircle (position, X, Y, Size);
		}

	}
}

