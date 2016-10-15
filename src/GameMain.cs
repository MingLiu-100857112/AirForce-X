using System;
using SwinGameSDK;

namespace MyGame
{
	public class GameMain
	{
		public static void Main ()
		{

			SwinGame.OpenGraphicsWindow ("GameMain", 600, 800);

			Controller gameController = new Controller ();
			gameController.EquipObjects ();
		

			while (false == SwinGame.WindowCloseRequested ()) {

				SwinGame.ProcessEvents ();
				SwinGame.ClearScreen (Color.White);


				SwinGame.RefreshScreen (60);

			}
		}
	}
}