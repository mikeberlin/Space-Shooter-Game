using System;
using System.Collections.Generic;
using Cocos2D;
using XNA = Microsoft.Xna.Framework;

namespace spaceshooter.ios
{
	public class HelloWorldLayer : CCLayerColor
	{
		public HelloWorldLayer ()
		{
			TouchEnabled = true;

			CCLabelTTF label = new CCLabelTTF ("Hello World!", "MarkerFelt", 64) {
				Position = CCDirector.SharedDirector.WinSize.Center,
				Color = new CCColor3B(XNA.Color.AntiqueWhite)
			};

			this.AddChild (label);

			Color = new CCColor3B (XNA.Color.ForestGreen);
			Opacity = 255;
		}

		public override void TouchesEnded (List<CCTouch> touches)
		{
			base.TouchesEnded (touches);

			//CCDirector.SharedDirector.ReplaceScene (HelloWorldLayer.Scene);
		}

		public static CCScene Scene
		{
			get {
				var scene = new CCScene ();
				scene.AddChild(new HelloWorldLayer ());
				return scene;
			}
		}
	}
}