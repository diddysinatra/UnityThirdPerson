// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Angles")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns the angle in degrees between two rotations A and B.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Angle (Quaternion)", "Returns the angle in degrees between two rotations A and B.")]
public class hyenApp_GetAngleQuaternion : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("A", "From Quaternion.")] Quaternion a,
		[FriendlyName("B", "To Quaternion.")] Quaternion b,
		[FriendlyName("Angle")] out float angle
	) {
		angle =  Quaternion.Angle(a, b);
	}
	
}
