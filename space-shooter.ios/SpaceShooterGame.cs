using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Cocos2D;

namespace spaceshooter.ios
{
	// this is the main type for your game
	public class SpaceShooterGame : Game
	{
		readonly GraphicsDeviceManager graphics;

		public SpaceShooterGame()
		{
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";
			graphics.IsFullScreen = false;

			CCApplication application = new SpaceShooterApplication (this, graphics);
			Components.Add (application);
		}
	}
}