// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns the length of this vector.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Magnitude Vector2", "Returns the length of this vector. The length of the vector is square root of (x*x+y*y).")]
public class hyenApp_MagnitudeVector2 : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Vector2")] Vector2 vector2, 
		[FriendlyName("Result")] out float result
	) {
		result = vector2.magnitude;
		
	}
	
}
