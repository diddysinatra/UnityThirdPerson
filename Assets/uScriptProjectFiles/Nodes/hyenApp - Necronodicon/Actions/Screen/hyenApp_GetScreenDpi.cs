// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Screen")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("The current DPI of the screen / device (Read Only).")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Screen Dpi", "The current DPI of the screen / device (Read Only). \n\nThis is the actual DPI of the screen attached or physical device running the application. May return 0 if unable to determine the current DPI.")]
public class hyenApp_GetScreenDpi : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Default Dpi", "(optional) Allows you to specify a DPI to return if the DPI is not found. Will return 0 if not specified."), DefaultValue(0f)] float DefaultDpi,
		[FriendlyName("Dpi", "Returns the current DPI of the screen / device.")] out float Dpi
	){
		if (Screen.dpi != 0f) {
			Dpi = Screen.dpi;
		} else {
			Dpi = DefaultDpi;
		}
		
	}
	
}
