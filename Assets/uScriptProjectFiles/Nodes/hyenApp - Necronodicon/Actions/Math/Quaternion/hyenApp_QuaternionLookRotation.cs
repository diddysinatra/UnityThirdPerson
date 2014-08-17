// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Quaternion")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Creates a rotation that looks along forward with the the head upwards.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Quaternion Look Rotation", "Creates a rotation that looks along forward with the the head upwards. \n\nLogs an error if the forward direction is zero.")]
public class hyenApp_QuaternionLookRotation : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Forward", "The Vector3 forward direction to create a Quaternion rotation from.")] Vector3 forward,
		[FriendlyName("Upwards", "The upwards direction to use if you do not want the default Vector3.up direction."), SocketState(false, false)] Vector3 upwards,
		[FriendlyName("Result", "The Quaternion result of the operation.")] out Quaternion result
	) {
		if(upwards != Vector3.zero) {
			result = Quaternion.LookRotation(forward, upwards);
			
		} else {
			result = Quaternion.LookRotation(forward);
			
		}
		
	}
	
}
