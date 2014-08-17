// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/AnimationClip")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a AnimationClip variable using the value of another AnimationClip variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set (AnimationClip)", "Sets the value of a AnimationClip variable using the value of another AnimationClip variable.")]
public class hyenApp_SetAnimationClip : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] AnimationClip Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out AnimationClip Target
	){
		Target = Value;
		
	}
	
}
