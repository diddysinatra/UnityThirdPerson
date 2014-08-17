// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Linearly interpolates between two vectors.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Lerp Vector3", "Linearly interpolates between two vectors. Interpolates From towards Fo by amount Time.\n Time is clamped between [0...1]. When Time = 0 returns From. When Time = 1 returns To. When Time = 0.5 returns the average of From and To.")]
public class hyenApp_LerpVector3 : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("From")] Vector3 start,
		[FriendlyName("To")] Vector3 end,
		[FriendlyName("Time")] float time,
		[FriendlyName("Result")] out Vector3 result
	) {
		result =  Vector3.Lerp(start, end, time);
		
	}
	
}
