// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the number of touches.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Get Touch Count", "Gets the number of touches. Guaranteed not to change throughout the frame. (Read Only)")]
public class hyenApp_InputGetTouchCount : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Touch Count", "The number of touches.")] out int touchCount
	) {
		touchCount = Input.touchCount;
		
	}
	
}
