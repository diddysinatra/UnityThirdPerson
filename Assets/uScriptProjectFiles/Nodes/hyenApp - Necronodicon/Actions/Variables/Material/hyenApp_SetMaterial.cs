// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a Material variable using the value of another Material variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Material", "Sets the value of a Material variable using the value of another Material variable.")]
public class hyenApp_SetMaterial : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Shader Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Shader TargetMaterial
	) {
		TargetMaterial = Value;
	}
	
}
