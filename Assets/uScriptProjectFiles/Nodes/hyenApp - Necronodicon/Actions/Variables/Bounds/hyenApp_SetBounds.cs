// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Bounds")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a Bounds variable using the value of another Bounds variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Bounds", "Sets the value of a Bounds variable using the value of another Bounds variable.")]
public class hyenApp_SetBounds : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Bounds Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Bounds Target
	) {
		Target = Value;
		
	}
	
}
