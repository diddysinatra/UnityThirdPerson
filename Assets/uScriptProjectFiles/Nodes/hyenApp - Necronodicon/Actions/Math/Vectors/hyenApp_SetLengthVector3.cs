// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns a vector of the specified Direction with the specified Length.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Length (Vector3)", "Returns a vector of the specified Direction with the specified Length.")]
public class hyenApp_SetLengthVector3 : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Direction")] Vector3 direction,
		[FriendlyName("Length")] float length,
		[FriendlyName("Result")] out Vector3 result
	) {
		result = direction.normalized * length;
		
	}
	
}
