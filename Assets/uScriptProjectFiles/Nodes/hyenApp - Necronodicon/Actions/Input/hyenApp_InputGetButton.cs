// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the input Held, Down, Up bool values identified by Button Name.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Get Button", "Gets the input Held, Down, Up bool values identified by Button Name.")]
public class hyenApp_InputGetButton : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Button Name", "The Button Name that identifies the input values, you want to get.")] string name,
		[FriendlyName("Held", "Returns true while the virtual button identified by Button Name is held down.")] out bool held,
		[FriendlyName("Down", "Returns true during the frame the user pressed down the virtual button identified by Button Name."), SocketState(false, false)] out bool down,
		[FriendlyName("Up", "Returns true the first frame the user releases the virtual button identified by Button Name."), SocketState(false, false)] out bool up
		
	) {
		held = Input.GetButton(name);
		down = Input.GetButtonDown(name);
		up = Input.GetButtonUp(name);
		
	}
	
}
