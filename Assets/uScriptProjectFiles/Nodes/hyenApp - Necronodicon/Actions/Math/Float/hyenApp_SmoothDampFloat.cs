// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gradually changes a value towards a desired goal over time.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Smooth Damp Float", "Gradually changes a value towards a desired goal over time. \n\nThe value is smoothed by some spring-damper like function, which will never overshoot. The function can be used to smooth any kind of value, positions, colors, scalars. \n\nCurrent: The current position. \nTarget: The position we are trying to reach. \nCurrent Velocity: The current velocity, this value is modified by the function every time you call it. \nSmooth Time: Approximately the time it will take to reach the target. A smaller value will reach the target faster. \nMax Speed: Optionally allows you to clamp the maximum speed. (Sorry this parameter is not supported yet!) \nDelta Time: Optionally allows you to set the time since the last call to this node. By default Time.deltaTime. (Sorry this parameter is not supported yet!)")]
public class hyenApp_SmoothDampFloat : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Current")] float current,
		[FriendlyName("Target")] float target,
		[FriendlyName("Current Velocity")] float currentVelocity,
		[FriendlyName("Smooth Time")] float smoothTime,
		//[FriendlyName("Max Speed"), SocketState(false, false)] float maxSpeed,
		//[FriendlyName("Delta Time"), SocketState(false, false)] float deltaTime,
		[FriendlyName("Result")] out float Result
	) {
		Result = Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime);
		
	}
	
}
