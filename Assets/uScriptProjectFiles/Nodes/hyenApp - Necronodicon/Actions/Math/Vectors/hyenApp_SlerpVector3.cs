

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]
[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Spherically interpolates between two vectors.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Slerp Vector3", "Inerpolates between From and To by amount Time. The returned vector's magnitude will be interpolated between magnitudes of from and to.")]
public class hyenApp_SlerpVector3 : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("From")] Vector3 start,
		[FriendlyName("To")] Vector3 end,
		[FriendlyName("Time")] float time,
		[FriendlyName("Result")] out Vector3 result
	) {
		result =  Vector3.Slerp(start, end, time);
		
	}
	
}
