// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Touch")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a Touch variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (Touch)", "Gets the components of a Touch variable. \n\nThe Touch class stores fingerId, position, deltaPosition, deltaTime, tapCount, & phase.")]
public class hyenApp_GetComponentsTouch : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Touch", "The target Touch.")] Touch touch,
		[FriendlyName("Finger Id", "The unique index for touch.")] out int fingerId,
		[FriendlyName("Position", "The position of the touch.")] out Vector2 position,
		[FriendlyName("Delta Position", "The position delta since last change.")] out Vector2 deltaPosition,
		[FriendlyName("Delta Time", "Amount of time passed since last change.")] out float deltaTime,
		[FriendlyName("Tap Count", "Number of taps.")] out int tapCount,
		[FriendlyName("Phase", "Describes the phase of the touch.")] out TouchPhase phase
	) {
		fingerId = touch.fingerId;
		position = touch.position;
		deltaPosition = touch.deltaPosition;
		deltaTime = touch.deltaTime;
		tapCount = touch.tapCount;
		phase = touch.phase;
		
	}
	
}
