// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Quaternion")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Creates a rotation From direction To direction.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.uscript.net/forum/viewtopic.php?f=21&t=1841")]

[FriendlyName("Set From To Rotation (Quaternion)", "Creates a rotation which rotates from the From Vector to the To Vector. \n\nUsually you use this to rotate a transform so that one of its axes eg. the y-axis - follows a target direction To direction in world space.")]
public class hyenApp_SetFromToRotationQuaternion : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("From Vector", "The From Vector component of the quaternion.")] Vector3 fromDirection,
		[FriendlyName("To Vector", "The To Vector component of the quaternion.")] Vector3 toDirection,
		[FriendlyName("Result Quaternion", "The quaternion calculated using the From and To vectors passed in.")] out Quaternion result
	) {
		result = Quaternion.FromToRotation(fromDirection, toDirection);
		
	}
	
}
