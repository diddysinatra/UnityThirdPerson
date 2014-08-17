// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Touch")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a Touch variable using the value of another Touch variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Touch", "Sets the value of a Touch variable using the value of another Touch variable.")]
public class hyenApp_SetTouch : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Touch Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Touch Target
	) {
		Target = Value;
		
	}
	
}
