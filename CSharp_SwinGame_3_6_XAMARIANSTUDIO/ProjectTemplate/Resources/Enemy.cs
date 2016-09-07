using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	public abstract class Enemy:Entity
	{
		private bool _orientation;
		int _speed;
		public Enemy ()
		{
			Random rnd = new Random ();
			int randSize = rnd.Next (1, 100);
			Size = randSize;
			int randX = rnd.Next (0, 100);
			int randY = rnd.Next (0, 600 - Size);
			int randSpeed = rnd.Next (1, 5);
			if (randX < 50)
			{
				X = (0 - Size);
				_orientation = true; 
			}
			else
			{
				X = 800;
				_orientation = false;
			}
			Y = randY;
			_speed = randSpeed;
		}

		public bool Orientation
		{
			get{
				return _orientation;
			}
		}

		public int Speed
		{
			get{
				return _speed;
			}
		}

		public abstract void Move ();
	}
}

