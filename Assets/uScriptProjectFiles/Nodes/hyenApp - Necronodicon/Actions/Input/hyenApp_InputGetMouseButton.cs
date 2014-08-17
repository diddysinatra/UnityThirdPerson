// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns whether the given mouse button is Held, Down, Up.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Get Mouse Button", "Returns whether the given mouse button is Held, Down, Up. \n\nButton values are 0 for left button, 1 for right button, 2 for the middle button.")]
public class hyenApp_InputGetMouseButton : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Mouse Button", "The Mouse Button index that identifies the mouse button, you want to get. (this value is clamped between 0 and 2)")] int index,
		[FriendlyName("Held", "Returns true while the Mouse Button is held down.")] out bool held,
		[FriendlyName("Down", "Returns true during the frame the user pressed down the Mouse Button."), SocketState(false, false)] out bool down,
		[FriendlyName("Up", "Returns true the first frame the user releases the Mouse Button."), SocketState(false, false)] out bool up
		
	) {
		int clampedIndex = Mathf.Clamp(index, 0, 2);
		held = Input.GetMouseButton(clampedIndex);
		down = Input.GetMouseButtonDown(clampedIndex);
		up = Input.GetMouseButtonUp(clampedIndex);
		
	}
	
}
