// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects/Movement")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Calculate orbit Position around Target GameObject.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.uscript.net/forum/viewtopic.php?f=21&t=1841")]

[FriendlyName("Orbit Position Around GameObject", "Calculate orbit Position around Target GameObject")]
public class hyenApp_OrbitPositionAroundGameObject : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Target", "The Target GameObject you wish to calculate the orbit Position around.")] GameObject target,
		[FriendlyName("Rotation X", "The Rotation X angle of the orbit you want to calculate around the Target GameObject.")] float rotationX,
		[FriendlyName("Rotation Y", "The Rotation Y angle of the orbit you want to calculate around the Target GameObject.")] float rotationY,
		[FriendlyName("Distance", "The Distance of the orbit from the Target GameObject")] float distance,
		//[FriendlyName("Invert Distance", ""), DefaultValue(true), SocketState(false, false)] bool invert,
		[FriendlyName("Result", "The Resulting orbit Position.")] out Vector3 result
	) {
		Quaternion rotation  = Quaternion.Euler(rotationX, rotationY, 0);
		Vector3 direction = new Vector3(0, 0, -distance);
		result = target.transform.position + rotation * direction;
		
	}
	
}
