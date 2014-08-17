// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Angles")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Clamps a float variable (angle) between a min and a max value and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Clamp Angle", "Clamps a float variable (angle) between a min and a max value and returns the result.")]
public class hyenApp_ClampAngle : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Angle", "The value to be clamped.")] float angle,
		[FriendlyName("Min", "The minimum value to clamp to.")] float min,
		[FriendlyName("Max", "The maximum value to clamp to.")] float max,
		[FriendlyName("Result", "Floating-point result of the clamp operation.")] out float floatResult,
		[FriendlyName("Int Result", "Integer result of the clamp operation."), SocketState(false, false)] out int intResult
	) {
		if (angle < -360)
			angle += 360;
		if (angle > 360)
			angle -= 360;
		
		floatResult = Mathf.Clamp(angle, min, max);
		intResult = System.Convert.ToInt32(floatResult);
		
	}
	
}
