// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets a list of objects representing status of all touches during last frame.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Get Touches", "Gets a list of objects representing status of all touches during last frame. (Read Only) (Allocates temporary variables) \n\nEach entry represents a status of a finger touching the screen.")]
public class hyenApp_InputGetTouches : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Touches", "")] out Touch[] touches
	) {
		touches = Input.touches;
		
	}
	
}
