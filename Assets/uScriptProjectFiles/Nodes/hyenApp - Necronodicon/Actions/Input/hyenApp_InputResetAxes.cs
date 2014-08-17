// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Resets all input. After ResetInputAxes all axes return to 0 and all buttons return to 0 for one frame.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Reset Axes", "Resets all input. After ResetInputAxes all axes return to 0 and all buttons return to 0 for one frame. \n\nThis can be useful when respawning the player and you don't want any input from keys that might still be held down.")]
public class hyenApp_InputResetAxes : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( ) {
		Input.ResetInputAxes( );
		
	}
	
}
