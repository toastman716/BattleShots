﻿using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public abstract class Entity
	{
		

		private int _x;
		private int _y;
		private int _size;

		public Entity ()
		{
		}

		public abstract void Draw (); 
		public abstract bool IsAt (Point2D position);

		public int X
		{
			get{
				return _x;
			}
			set{
				_x = value;
			}
		}

		public int Y
		{
			get{
				return _y;
			}
			set{
				_y = value;
			}
		}

		public int Size
		{
			get{
				return _size;
			}
			set{
				_size = value;
			}
		}
	}
}

