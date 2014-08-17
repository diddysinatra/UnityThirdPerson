// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Linearly interpolates between two vectors.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Lerp Vector2", "Linearly interpolates between two vectors. Interpolates From towards Fo by amount Time.\n Time is clamped between [0...1]. When Time = 0 returns From. When Time = 1 returns To. When Time = 0.5 returns the average of From and To.")]
public class hyenApp_LerpVector2 : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("From")] Vector2 start,
		[FriendlyName("To")] Vector2 end,
		[FriendlyName("Time")] float time,
		[FriendlyName("Result")] out Vector2 result
	) {
		result =  Vector2.Lerp(start, end, time);
		
	}
	
}
