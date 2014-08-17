// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System;

[NodePath("Actions/Variables/Lists/Collider")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets a Collider List to the defined value.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set List (Collider)", "Sets a Collider List to the defined value.")]
public class hyenApp_SetListCollider : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Collider[] Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Collider[] Target
	) {
		Target = Value;
		
	}
	
}
