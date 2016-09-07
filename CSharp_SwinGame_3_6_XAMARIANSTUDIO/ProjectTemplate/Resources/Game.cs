using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class Game
	{
		private int _score;
		private Player _player;
		private List<Enemy> _enemies = new List<Enemy>();
		public Game ()
		{
			_player = new Player();
		}

		public void DrawGame()
		{
			SwinGame.DrawText ("Score: " + _score, Color.Black, 0, 0);
			_player.Draw ();
			foreach (Enemy e in _enemies)
			{
				e.Draw ();
				e.Move ();
 
			}

		}

		public void Begin()
		{
			Random rnd = new Random ();
			int rand = rnd.Next (3,25);
			for (int i = 0; i < 5; i++)
			{
//				int randType = rnd.Next (0,3);
				EnemySquare en = new EnemySquare(); 
				_enemies.Add (en);
			}
		}
			
		public void Consume()
		{
			int scoreDiff = 0;
			List<Enemy> toRemove = new List<Enemy> ();
			Point2D pt = SwinGame.PointAt (_player.X, _player.Y);
			foreach (Enemy e in _enemies)
			{
				if (e.IsAt (pt))
				{
					if (_player.Size > e.Size)
					{
						_player.Size += Convert.ToInt32(e.Size/20);
						scoreDiff += e.Size;
						toRemove.Add (e);
					}
					else
						EndGame ();
				}
			}

			foreach (Enemy e in toRemove)
			{
				_enemies.Remove (e);
			}

			_score += scoreDiff;
		}

		public void EndGame()
		{
			
		}

		public int Score
		{
			get{
				return _score;
			}
			set{
				_score = value;
			}
		}

		public Player Player
		{
			get{
				return _player;
			}
			set{
				_player = value;
			}
		}
	}
}

