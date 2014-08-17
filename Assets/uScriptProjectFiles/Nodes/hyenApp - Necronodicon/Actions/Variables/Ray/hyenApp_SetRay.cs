// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Ray")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a Ray variable using the value of another Ray variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Ray", "Sets the value of a Ray variable using the value of another Ray variable.")]
public class hyenApp_SetRay : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Ray Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Ray Target
	) {
		Target = Value;
		
	}
	
}
