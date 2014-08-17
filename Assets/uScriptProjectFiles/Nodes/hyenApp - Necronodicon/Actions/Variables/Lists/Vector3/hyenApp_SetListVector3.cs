// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System;

[NodePath("Actions/Variables/Lists/Vector3")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets a Vector3 List to the defined value.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set List (Vector3)", "Sets a Vector3 List to the defined value.")]
public class hyenApp_SetListVector3 : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Vector3[] Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Vector3[] Target
	) {
		Target = Value;
	}
	
}
