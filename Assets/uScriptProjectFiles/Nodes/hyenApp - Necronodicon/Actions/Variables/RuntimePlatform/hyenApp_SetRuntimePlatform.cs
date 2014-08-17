// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/RuntimePlatform")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a RuntimePlatform variable using the value of another RuntimePlatform variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set RuntimePlatform", "Sets the value of a RuntimePlatform variable using the value of another RuntimePlatform variable.")]
public class hyenApp_SetRuntimePlatform : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] RuntimePlatform Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out RuntimePlatform TargetRuntimePlatform
	) {
		TargetRuntimePlatform = Value;
		
	}
	
}