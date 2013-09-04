using System;
using MonoTouch.Foundation;
using MonoTouch.CoreAnimation;
using MonoTouch.UIKit;
using Cocos2D;
using CocosDenshion;
using Microsoft.Xna.Framework;

namespace spaceshooter.ios
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		SpaceShooterGame spaceShooterGame;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override void FinishedLaunching (UIApplication app)
		{
			// create a new window instance based on the screen size
			spaceShooterGame = new SpaceShooterGame ();
			spaceShooterGame.Run ();
		}
	}
}