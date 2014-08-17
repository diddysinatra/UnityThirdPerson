// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the input Held, Down, Up bool values identified by Key Name.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Get Key", "Gets the input Held, Down, Up bool values identified by Key Name. \n\nFor the list of key identifiers see Input Manager in the Unity documentation. When dealing with input it is recommended to use 'Get Axis' and 'Get Button' instead since it allows end-users to configure the keys. \n\nIf no Key Name or Key Code is specified KeyCode.None will be used.")]
public class hyenApp_InputGetKey : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Key Name", "The Key Name that identifies the input values, you want to get.")] string name,
		[FriendlyName("Key Code", "The Key Code that identifies the input values, you want to get."), SocketState(false, false), DefaultValue(KeyCode.None)] KeyCode code,
		[FriendlyName("Held", "Returns true while the virtual key identified by Key Name is held down.")] out bool held,
		[FriendlyName("Down", "Returns true during the frame the user pressed down the virtual key identified by Key Name."), SocketState(false, false)] out bool down,
		[FriendlyName("Up", "Returns true the first frame the user releases the virtual key identified by Key Name."), SocketState(false, false)] out bool up
		
	) {
		if (name != "") {
			held = Input.GetKey(name);
			down = Input.GetKeyDown(name);
			up = Input.GetKeyUp(name);
		} else {
			held = Input.GetKey(code);
			down = Input.GetKeyDown(code);
			up = Input.GetKeyUp(code);
		}
		
	}
	
}
