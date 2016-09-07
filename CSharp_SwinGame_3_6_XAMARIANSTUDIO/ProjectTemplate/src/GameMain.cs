using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
			Game game = new Game ();
            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 800, 600);

			game.Player.X = (SwinGame.ScreenWidth () / 2);
			game.Player.Y = (SwinGame.ScreenHeight () / 2);
//			game.Begin ();
            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {

                //Fetch the next batch of UI interaction//
                SwinGame.ProcessEvents();
                
				if (SwinGame.KeyDown (KeyCode.vk_DOWN)&&game.Player.Y<(SwinGame.ScreenHeight ()-game.Player.Size) )
				{
					game.Player.Y+=3;
				}
				if (SwinGame.KeyDown (KeyCode.vk_UP)&&game.Player.Y>0)
				{
					game.Player.Y-=3;
				}
				if (SwinGame.KeyDown (KeyCode.vk_LEFT)&&game.Player.X>0)
				{
					game.Player.X-=3;
				}
				if (SwinGame.KeyDown (KeyCode.vk_RIGHT)&&game.Player.X<(SwinGame.ScreenWidth ()-game.Player.Size))
				{
					game.Player.X+=3;
				}
				if (SwinGame.KeyTyped (KeyCode.vk_SPACE))
				{
					game.Begin ();
				}
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);
//				game.Begin ();
				game.DrawGame ();
				game.Consume ();
                SwinGame.RefreshScreen(60);
            }
        }
    }
} 