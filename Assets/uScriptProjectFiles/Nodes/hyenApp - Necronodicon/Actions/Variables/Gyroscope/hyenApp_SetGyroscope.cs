// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Gyroscope")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a Gyroscope variable using the value of another Gyroscope variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Gyroscope", "Sets the value of a Gyroscope variable using the value of another Gyroscope variable.")]
public class hyenApp_SetGyroscope : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Gyroscope Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Gyroscope Target
	) {
		Target = Value;
		
	}
	
}
