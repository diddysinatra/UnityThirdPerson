// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Animation")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the length of the animation clip in seconds.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Length (Animation)", "Gets the length of the animation clip in seconds.")]
public class hyenApp_GetLengthAnimation : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target GameObject to get the current length from.")] GameObject target,
		[FriendlyName("Animation", "The Animation name you want to get the current length for.")] string animation,
		[FriendlyName("Length", "The current length of the animation.")] out float length
	) {
		length = target.animation[animation].length;
		
	}
	
}
