// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Screen")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets logical orientation of the screen.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Orientation", "Sets logical orientation of the screen. \n\nDefault value is taken from the 'Default Orientation' in Player Settings. \n\nCurrently screen orientation is only relevant on mobile platforms.")]
public class hyenApp_SetScreenOrientation : uScriptLogic {

	public bool Out { get { return true; } }
	
	[FriendlyName("Portrait")] 
	public void Portrait() {
		Screen.orientation = ScreenOrientation.Portrait;
	}
	
	[FriendlyName("Portrait Upside Down")] 
	public void PortraitUpsideDown() {
		Screen.orientation = ScreenOrientation.PortraitUpsideDown;
	}
	
	[FriendlyName("Landscape Left")] 
	public void LandscapeLeft() {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	[FriendlyName("Landscape Right")] 
	public void LandscapeRight() {
		Screen.orientation = ScreenOrientation.LandscapeRight;
	}
	
}
