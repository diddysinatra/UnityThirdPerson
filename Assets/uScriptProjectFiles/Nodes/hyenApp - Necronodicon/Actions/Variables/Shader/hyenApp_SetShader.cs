// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Shader")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a Shader variable using the value of another Shader variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Shader", "Sets the value of a Shader variable using the value of another Shader variable.")]
public class hyenApp_SetShader : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Shader Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Shader TargetShader
	) {
		TargetShader = Value;
	}

}
