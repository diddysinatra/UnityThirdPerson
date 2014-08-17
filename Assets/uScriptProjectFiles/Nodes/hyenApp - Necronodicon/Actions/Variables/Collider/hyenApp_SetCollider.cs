// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Collider")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a Collider variable using the value of another Collider variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Collider", "Sets the value of a Collider variable using the value of another Collider variable.")]
public class hyenApp_SetCollider : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Collider Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Collider Target
	) {
		Target = Value;
		
	}
	
}
