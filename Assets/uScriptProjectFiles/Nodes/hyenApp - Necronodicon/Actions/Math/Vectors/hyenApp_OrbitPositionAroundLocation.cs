// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Calculate orbit Position around Location.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.uscript.net/forum/viewtopic.php?f=21&t=1841")]

[FriendlyName("Orbit Position Around Location", "Calculate orbit Position around Location")]
public class hyenApp_OrbitPositionAroundLocation : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Location", "The Location you wish to calculate the orbit Position around.")] Vector3 location,
		[FriendlyName("Rotation X", "The Rotation X angle of the orbit you want to calculate around the Location.")] float rotationX,
		[FriendlyName("Rotation Y", "The Rotation Y angle of the orbit you want to calculate around the Location.")] float rotationY,
		[FriendlyName("Distance", "The Distance of the orbit from the Location")] float distance,
		//[FriendlyName("Invert Distance", ""), DefaultValue(true), SocketState(false, false)] bool invert,
		[FriendlyName("Result", "The Resulting orbit Position.")] out Vector3 result
	) {
		Quaternion rotation  = Quaternion.Euler(rotationX, rotationY, 0);
		Vector3 direction = new Vector3(0, 0, -distance);
		result = location + rotation * direction;
		
   }
	
}
