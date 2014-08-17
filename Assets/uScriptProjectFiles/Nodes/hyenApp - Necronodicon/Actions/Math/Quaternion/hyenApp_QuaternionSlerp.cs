// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Quaternion")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Spherically interpolates between two Quaternions.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Quaternion Slerp", "Inerpolates between From and To by amount Time. The returned Quaternion's magnitude will be interpolated between magnitudes of from and to.")]
public class hyenApp_QuaternionSlerp : uScriptLogic {

		public bool Out { get { return true; } }

	public void In(
		[FriendlyName("From")] Quaternion start,
		[FriendlyName("To")] Quaternion end,
		[FriendlyName("Time")] float time,
		[FriendlyName("Result")] out Quaternion result
	) {
		result =  Quaternion.Slerp(start, end, time);
		
	}
	
}
