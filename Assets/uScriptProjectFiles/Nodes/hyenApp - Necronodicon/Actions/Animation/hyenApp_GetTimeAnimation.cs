// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Animation")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the current time of the animation.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Time (Animation)", "Gets the current time of the animation. \n\nIf the time is larger than length it will be wrapped according to wrapMode. The value can be larger than the animations length. In this case playback mode will remap the time before sampling. This value usually goes from 0 to infinity.")]
public class hyenApp_GetTimeAnimation : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target GameObject to get the current time from.")] GameObject target,
		[FriendlyName("Animation", "The Animation name you want to get the current time for.")] string animation,
		[FriendlyName("Time", "The current time of the animation.")] out float time
	) {
		time = target.animation[animation].time;
		
	}
	
}
