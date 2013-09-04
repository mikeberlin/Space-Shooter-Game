using System;
using Microsoft.Xna.Framework;
using Cocos2D;
using CocosDenshion;

namespace spaceshooter.ios
{
	public class SpaceShooterApplication : CCApplication
	{
		public SpaceShooterApplication (Game game, GraphicsDeviceManager graphics)
			: base(game, graphics)
		{
			s_pSharedApplication = this;
			CCDrawManager.InitializeDisplay (game, graphics, DisplayOrientation.Portrait);
			graphics.PreferMultiSampling = false;
		}

		public override bool ApplicationDidFinishLaunching ()
		{
			// initialize director
			CCDirector director = CCDirector.SharedDirector;
			director.SetOpenGlView ();

			director.Projection = CCDirectorProjection.Projection2D;
			director.DisplayStats = false;

			director.AnimationInterval = (1.0 / 60);

			CCScene scene = HelloWorldLayer.Scene;
			director.RunWithScene (scene);

			return true;
		}

		public override void ApplicationDidEnterBackground ()
		{
			// stop all of the animation actions that are running
			CCDirector.SharedDirector.Pause ();

			// if you use SimpleAudioEngine, your music must be paused
			//CCSimpleAudioEngine.SharedEngine.PauseBackgroundMusic = true;
		}

		public override void ApplicationWillEnterForeground ()
		{
			CCDirector.SharedDirector.Resume ();

			// if you use SimpleAudioEngine, your background music track must resume here
			//CCSimpleAudioEngine.SharedEngine.PauseBackgroundMusic = false;
		}
	}
}