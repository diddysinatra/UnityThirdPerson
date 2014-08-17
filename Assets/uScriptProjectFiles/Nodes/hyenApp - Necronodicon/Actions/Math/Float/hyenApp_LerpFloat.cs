// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Linearly interpolates between two floats.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Lerp Float", "Linearly interpolates between two floats. Interpolates From towards Fo by amount Time.\n Time is clamped between [0...1]. When Time = 0 returns From. When Time = 1 returns To. When Time = 0.5 returns the average of From and To.")]
public class hyenApp_LerpFloat : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("From")] float start,
		[FriendlyName("To")] float end,
		[FriendlyName("Time")] float time,
		[FriendlyName("Result")] out float result
	) {
		result =  Mathf.Lerp(start, end, time);
		
	}
	
}
