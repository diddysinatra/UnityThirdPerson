// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Vector3")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get Vector3 class variables for: zero, one, forward, up, and right.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.uscript.net/forum/viewtopic.php?f=21&t=1841")]

[FriendlyName("Get Class Variables (Vector3)", "Get Vector3 class variables for: zero, one, forward, up, and right.")]
public class hyenApp_GetClassVariablesVector3 : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Zero", "Shorthand for writing Vector3(0, 0, 0)")] out Vector3 zero,
		[FriendlyName("One", "Shorthand for writing Vector3(1, 1, 1)")] out Vector3 one,
		[FriendlyName("Forward", "Shorthand for writing Vector3(0, 0, 1)")] out Vector3 forward,
		[FriendlyName("Up", "Shorthand for writing Vector3(0, 1, 0)")] out Vector3 up,
		[FriendlyName("Right", "Shorthand for writing Vector3(1, 0, 0)")] out Vector3 right
	) {
		zero = Vector3.zero;
		one = Vector3.one;
		forward = Vector3.forward;
		up = Vector3.up;
		right = Vector3.right;
		
	}
	
}
