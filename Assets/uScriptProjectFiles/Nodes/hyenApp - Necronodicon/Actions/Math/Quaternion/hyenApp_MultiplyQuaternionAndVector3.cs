// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Quaternion")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Multiplies a Quaternion and Vector3 variables together and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Multiply Quaternion And Vector3", "Multiplies a Quaternion and Vector3 variables together and returns the result.")]
public class hyenApp_MultiplyQuaternionAndVector3 : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("A", "The first Quaternion variable.")] Quaternion A,
		[FriendlyName("B", "The second Vector3 variable.")] Vector3 B,
		[FriendlyName("Result", "The Vector3 result of the operation.")] out Vector3 Result
	) {
		Result = A * B;
		
	}
	
}
