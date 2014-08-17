// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Quaternion")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Multiplies two Quaternion variables together and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Multiply Quaternion", "Multiplies two Quaternion variables together and returns the result.")]
public class hyenApp_MultiplyQuaternion : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("A", "The first variable.")] Quaternion A,
		[FriendlyName("B", "The second variable.")] Quaternion B,
		[FriendlyName("Result", "The Quaternion result of the operation.")] out Quaternion Result
	) {
		Result = A * B;
		
	}
	
}
