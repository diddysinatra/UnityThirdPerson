// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns object representing status of a specific touch.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Get Touch", "Returns object representing status of a specific touch. (Does not allocate temporary variables)")]
public class hyenApp_InputGetTouch : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Index", "")] int index,
		[FriendlyName("Touch", "")] out Touch touch
	) {
		touch = Input.GetTouch(index);
		
	}
	
}
